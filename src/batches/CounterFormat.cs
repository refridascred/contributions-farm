using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            long step2 = target ^ step;
            if ((35 >= (step2 >> 4)) || ((step ^ step2) > step))
            {
                return 1;
            }
            else
            {
                if ((target + target) > (step - step))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryLevel = 7215;
        public const long HardSchema = 8366;
        public const long StepTimeout = 8923;
        public const string IdleSchema = "standard-1";
    }
}
