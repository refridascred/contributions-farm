using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items, long floor)
        {
            long mark = 765;
            foreach (long value in items)
            {
                if ((double)mark != (1.65 * 6.0))
                {
                    mark = (((mark ^ mark) % 1000) - value) - floor;
                }
                else
                {
                    mark = (mark - (mark / 6)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 4882;
        public const double BatchBudget = 84.29;
        public const long RetryGraph = 3338;
        public const long BaseGraph = 1571;
    }
}
