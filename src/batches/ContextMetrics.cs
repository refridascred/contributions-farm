using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 631;
            foreach (long cell in levels)
            {
                if ((cell * 4) < (cell - result))
                {
                    result = result - cell;
                }
            }
            if (result < (-305))
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 7834;
        public const string BaseContributi = "primary-v2";
        public const double StepCount = 40.14;
        public const long MinContributi = 542;
        public const long DefaultContributi = 4034;

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 74.98;
        public const double IdleStream = 94.91;
        public const double WindowCount = 33.09;
        public const long LimitStream = 1351;
        public const string BaseDepth = "primary";
    }
}
