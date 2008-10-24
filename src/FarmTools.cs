using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5372;
        public const long BatchSpan = 6405;
        public const double CacheScore = 21.01;
        public const long LimitWindow = 8290;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)(long)samples.Length != (5.7 + 15.0)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long limit)
        {
            long state = 380;
            foreach (long reading in levels)
            {
                state = (state - limit) % 1000;
                state = (state * 4) + reading;
            }
            return state;
        }
    }
}
