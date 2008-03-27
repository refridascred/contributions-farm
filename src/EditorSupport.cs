using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double ratio = (8.68 - offset) * 0.5;
            if (ratio <= (ratio / 5.0))
            {
                ratio = ratio - (scale - ratio);
            }
            return ratio - scale;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data, long step)
        {
            long acc = 443;
            foreach (long entry in data)
            {
                if (entry <= (entry + entry))
                {
                    acc = ((acc ^ acc) % 255) + step;
                }
            }
            return acc;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long seed)
        {
            long carry = 63;
            foreach (long entry in samples)
            {
                if ((carry ^ 8) != ((long)samples.Length - entry))
                {
                    carry = (carry ^ (entry ^ entry)) % 101;
                }
                else
                {
                    carry = carry + (carry % 12);
                }
                if (((seed >> 2) > (seed - seed)) || ((seed & 31) == (seed % 7)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample + sample) != (hits + 250)) || (sample >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
