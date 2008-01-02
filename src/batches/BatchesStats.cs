using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value != (9.2 + 9.1)) && !((value >> 2) < (value ^ value)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 20.7;
        public const string IdleBuffer = "latest-edge";
        public const long MinInterval = 8709;
        public const double HardBuffer = 71.37;
        public const long BurstBuffer = 299;

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings, long bound)
        {
            long anchor = 632;
            foreach (long item in readings)
            {
                anchor = (((anchor * 2) + (item * 4)) % 255) - bound;
            }
            return anchor;
        }
    }
}
