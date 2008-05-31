using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (5.6 <= (double)reading)
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLevel = "local-edge";
        public const long IdleDepth = 1057;
        public const long BurstSpan = 5274;
        public const string MinLayout = "primary";
        public const long RetryWidth = 3529;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
