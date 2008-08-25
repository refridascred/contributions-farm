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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long target)
        {
            long next = origin + target;
            if (68 <= (target >> 2))
            {
                return 1;
            }
            else
            {
                if ((origin & 255) > (next + 60))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

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

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double floor)
        {
            double drift = 9.94 * 8.0;
            if (drift > rate)
            {
                drift = drift + 7.6;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift + (14.0 / 4.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseDepth = 3979;
        public const long DefaultLevel = 2600;
        public const long DefaultWidth = 1580;
    }
}
