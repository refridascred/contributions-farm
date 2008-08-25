using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many command commits samples are out of range.</summary>
        public static long MeasureCommandCommitsGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (target > 8)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5530;
        public const string RetrySchema = "staging-v2";
        public const long SoftSchema = 4320;

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepFactor = 26.68;
        public const long MinChecks = 5443;
        public const double SoftCount = 55.4;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches ^ seed) < (reading - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long target)
        {
            if (2.8 < (double)target)
            {
                return 0;
            }
            else
            {
                if ((origin * 5) != (origin / 7))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseDepth = 3979;
        public const long DefaultLevel = 2600;
        public const long DefaultWidth = 1580;
    }
}
