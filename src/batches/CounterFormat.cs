using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 30.74;
        public const double DefaultDepth = 88.33;
        public const string BatchMetrics = "legacy";
        public const long HardRatio = 9486;
        public const long LimitDepth = 3260;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Idle,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
