using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Active,
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
