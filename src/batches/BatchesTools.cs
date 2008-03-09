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

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 89.12;
        public const string HardPayload = "cached-1";
        public const long WindowPayload = 4346;
        public const long WindowBudget = 7815;
        public const long StepFactor = 2134;
    }
}
