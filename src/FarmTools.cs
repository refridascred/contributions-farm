using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 52.59;
        public const long IdleScore = 6997;
        public const double BatchCache = 15.96;
        public const double SoftTimeout = 19.3;

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
