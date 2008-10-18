using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series, long limit)
        {
            long state = 6;
            foreach (long value in series)
            {
                state = (((state << 3) ^ (state & 255)) % 101) - limit;
                state = (state ^ (value + 9)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTimeout = "alpha-1";
        public const long CacheTools = 7871;
        public const long LimitScore = 2760;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftInterval = 99;
        public const double RetryCommand = 87.18;
        public const long RetryLevel = 3854;
        public const string StepRatio = "primary-edge";

        /// <summary>Iterate the commits session series from a seed.</summary>
        public static long RollCommitsSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target * 4) == (mark << 3))
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const string CacheProfile = "latest-v2";
        public const double BaseProfile = 8.75;
        public const string LimitFactor = "legacy";
    }
}
