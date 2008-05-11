using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (17.0 - 3.7))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
