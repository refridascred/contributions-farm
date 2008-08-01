using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Check that every stream commits entry stays within the limit.</summary>
        public static bool CheckStreamCommitsRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a format payload sample.</summary>
        public static long SeekFormatPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSpan = 23.68;
        public const string RetrySupport = "stable-v2";
        public const long BurstSupport = 1216;
        public const long WindowWidth = 7044;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 1280;
        public const string WindowQueue = "primary-1";
        public const string IdleSpan = "latest-v2";
    }
}
