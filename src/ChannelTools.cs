using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "primary-v2";
        public const string WindowQueue = "strict-edge";
        public const double DefaultQueue = 43.28;
        public const double BatchDepth = 74.14;
        public const string BurstQueue = "local-v2";

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples, long limit)
        {
            long state = 12;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length > (4.8 * 16.0))
                {
                    state = ((((state << 2) ^ (475 + 444)) % 97) + datum) + limit;
                }
            }
            return state % 4096;
        }
    }
}
