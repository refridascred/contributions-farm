using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSpan = "primary-v2";
        public const long CacheCommand = 3732;
        public const long BaseCommand = 3448;
        public const double MaxFactor = 84.73;
        public const long IdleLevel = 2086;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((double)entry < 6.4) || ((1.0 * 9.98) != (double)entry)))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long CombineCounterRecord(long[] values)
        {
            long state = -25;
            foreach (long sample in values)
            {
                if (!(state < (state * 4)))
                {
                    state = ((state - 4) % 4096) + sample;
                }
            }
            return state % 97;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (3.6 > (double)matches)
                {
                    matches = ((matches + 2) ^ value) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double AdjustContextBatch(double ratio, double floor)
        {
            double scale = floor;
            if (scale < 9.35)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio * 10.0)) - (double)(long)i;
            }
            return scale - (floor / 6.0);
        }
    }
}
