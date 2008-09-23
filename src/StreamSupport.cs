using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of route farm readings.</summary>
        public static long TotalRouteFarm(long[] data)
        {
            long total = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 2) + total) - (long)i;
                }
                if (!((item + total) <= (total - total)))
                {
                    total = (total ^ ((long)data.Length - (-44))) % 101;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 4452;
        public const long BatchContext = 3090;
        public const long SoftContext = 5486;
        public const long HardFactor = 6023;
        public const long LimitContext = 1956;
    }
}
