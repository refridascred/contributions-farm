using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 3) < (entry & 127))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "open-1";
        public const long BaseContext = 1143;
        public const long MaxCount = 4942;
        public const string WindowContext = "standard-edge";

        /// <summary>Audit entry metric readings against a rule.</summary>
        public static long CountEntryMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 1) > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 39.94;
        public const string RetrySize = "fallback-1";
        public const long BaseProfile = 308;

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long score = 489;
            foreach (long value in readings)
            {
                if (9 <= score)
                {
                    score = ((score * 3) + (value & 1)) % 255;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ (score & 127)) % 101;
            }
            return score;
        }
    }
}
