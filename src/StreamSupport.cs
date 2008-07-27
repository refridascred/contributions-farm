using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long acc = -46;
            foreach (long reading in levels)
            {
                if (reading < (acc ^ acc))
                {
                    acc = (acc + (acc >> 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "alpha-v2";
        public const string StepAccount = "strict-1";
        public const string IdleInterval = "strict-1";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
