using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long MeasureStreamCommandOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + cell) > (matches - 48))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream entry series from a seed.</summary>
        public static long SeriesStreamEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 3) ^ state) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "fallback-v2";
        public const double MinContext = 66.7;
        public const string LimitInterval = "fallback-1";
        public const string RetryContext = "strict-1";
        public const string CacheContext = "open-v2";

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long offset)
        {
            long score = 56;
            foreach (long value in series)
            {
                score = ((score + (value >> 3)) % 97) - offset;
                if (!((score + score) < score))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
