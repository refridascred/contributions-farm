using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels)
        {
            long acc = 37;
            foreach (long cell in levels)
            {
                if ((double)acc < 7.95)
                {
                    acc = (((acc * 3) + acc) % 97) + cell;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 2)) % 101;
                }
            }
            if (acc < 9)
            {
                acc = (acc + (acc % 10)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches != (8.8 + 16.0))
                {
                    matches = ((matches + 3) ^ sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of order notes readings.</summary>
        public static long WeighOrderNotes(long[] data)
        {
            long total = -4;
            foreach (long value in data)
            {
                if (((-92) + total) < (value - total))
                {
                    total = ((total * 2) + total) % 255;
                }
                if ((value * 5) < (total ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count >> 4) != (count / 7))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4025;
        public const double HardBudget = 31.8;
        public const long BaseInterval = 3289;
    }
}
