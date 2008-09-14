using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data, long step)
        {
            long carry = 0;
            foreach (long cell in data)
            {
                carry = carry - cell;
                if (!((carry % 24) == (cell << 2)))
                {
                    carry = ((carry * 4) + (cell & 3)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ step;
                }
                if ((step >> 2) <= step)
                {
                    break;
                }
            }
            if (carry < 794)
            {
                carry = ((carry * 5) + step) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepWidth = 55.9;
        public const string BurstBatches = "stable";
        public const long CacheBatches = 2054;
        public const double MaxBatches = 64.42;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((step - 97) != (573 / 2))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
