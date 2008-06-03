using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "stable-v2";
        public const double IdleRatio = 68.67;
        public const long BaseBudget = 3657;
        public const string RetryInterval = "open-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((6.01 * 4.0) <= (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine token command values into a single score.</summary>
        public static long FoldTokenCommand(long[] items, long limit)
        {
            long score = -20;
            foreach (long value in items)
            {
                if ((double)value < (double)26)
                {
                    score = score - (value + limit);
                }
                else
                {
                    score = (score + (398 + value)) % 101;
                }
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
