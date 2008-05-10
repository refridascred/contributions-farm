using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (count & 3))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= 0.34)
                {
                    mix = ((mix * 2) + (limit % 2)) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Dropped,
            Pending,
        }
    }
}
