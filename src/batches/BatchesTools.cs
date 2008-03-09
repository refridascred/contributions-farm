using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Locked,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long step)
        {
            long span = limit ^ step;
            if ((31 > (span - 91)) || ((5 ^ span) >= step))
            {
                return 0;
            }
            else
            {
                if ((double)step == (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1157;
        public const string RetryCommand = "cached-v2";
        public const string BatchCommand = "cached-edge";
    }
}
