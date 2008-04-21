using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long MeasureRouteFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (884 - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Synced,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 1451;
        public const long StepContributi = 8369;
        public const string IdleScore = "cached-v2";
        public const long MaxSpan = 7343;
        public const string CacheCount = "fallback-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9942;
        public const long HardScore = 5219;
        public const long BatchAlready = 8462;

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long SeekRouteChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
