using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a account stream reading.</summary>
        public static double BlendAccountStream(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 - offset) + rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 9376;
        public const long IdleInterval = 5660;
        public const long DefaultFactor = 1940;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
