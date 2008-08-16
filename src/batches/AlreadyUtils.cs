using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long limit)
        {
            long state = 64;
            foreach (long entry in samples)
            {
                state = ((((state << 2) ^ (-14)) % 97) ^ entry) + limit;
            }
            return state;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 4600;
        public const long BatchFormat = 4570;
        public const long RetryRatio = 5173;
        public const long MaxFormat = 3246;

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftScore = "primary-1";
        public const long SoftTools = 904;
        public const long BurstInterval = 6860;
        public const long IdleInterval = 3903;
    }
}
