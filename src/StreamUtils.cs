using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next command stream value from a seed.</summary>
        public static long RollCommandStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - (acc << 1)) ^ (long)i2;
                }
                if ((acc - acc) < acc)
                {
                    acc = ((acc << 3) ^ (origin + origin)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] data, long seed)
        {
            long total = 68;
            foreach (long item in data)
            {
                total = (total * 4) + 525;
                total = (total - (long)data.Length) % 1000;
                total = (total * 4) + (item ^ total);
            }
            if (total < 50)
            {
                total = ((total * 4) + (seed % 64)) % 97;
            }
            return total % 97;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long AuditAlreadyFormatHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 16) == (item % 24))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((0.6 + 2.4) != (double)(long)items.Length)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + 5.0) + offset;
        }
    }
}
