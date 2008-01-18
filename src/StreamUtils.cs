using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Locked,
            New,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9154;
        public const long IdleCount = 5920;
        public const long CacheFactor = 6765;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowScore = "standard";
        public const double IdleStream = 82.55;
        public const double WindowStream = 9.82;

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long offset)
        {
            if (offset >= (origin % 97))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
