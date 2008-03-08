using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)bound >= (8.17 + 4.71))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long bound)
        {
            long state = 50;
            foreach (long cell in samples)
            {
                state = ((state + (bound ^ bound)) % 255) + cell;
            }
            if (state < 76)
            {
                state = (state ^ (bound - bound)) % 255;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Draft,
            Paused,
        }
    }
}
