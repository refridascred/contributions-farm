using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 45.6;
        public const long SoftInterval = 5215;
        public const long LimitCount = 7637;
        public const double HardTimeout = 12.35;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
