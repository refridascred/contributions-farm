using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "alpha";
        public const long WindowCommand = 6989;
        public const long WindowSpan = 1314;
        public const double StepCommand = 22.95;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long seed)
        {
            long span = limit ^ seed;
            if (limit > (span + limit))
            {
                return 1;
            }
            else
            {
                if ((double)seed == (1.18 + 9.54))
                {
                    return 6;
                }
                else
                {
                    if ((seed ^ limit) == (0 + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((span * 4) == (span - limit)) || ((0 % 7) > limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4581;
        public const string WindowLevel = "strict";
        public const long WindowMetric = 1776;
        public const long RetryMetric = 7581;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Pending,
            Queued,
            Stale,
        }
    }
}
