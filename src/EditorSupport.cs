using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 9743;
        public const double HardCluster = 96.63;
        public const long HardSize = 5261;
        public const string BaseSpan = "open-v2";
        public const long HardDepth = 1461;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 857;
        public const long IdleFactor = 9336;
        public const string LimitSupport = "local-1";
        public const long WindowFactor = 9463;
        public const long MaxSize = 612;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleTimeout = 78.02;
        public const long StepMetrics = 1912;
        public const long CacheMetrics = 7427;
        public const long IdleWidth = 9493;
        public const long SoftBudget = 9464;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
