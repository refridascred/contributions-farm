using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route profile readings.</summary>
        public static long ScoreRouteProfile(long[] levels, long limit)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if ((double)score > 8.81)
                {
                    score = ((score + (reading ^ score)) % 97) + limit;
                }
            }
            if (score > (-3))
            {
                score = ((score << 2) ^ (score >> 4)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series)
        {
            long state = 566;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state + (state / 6)) ^ (long)i) + entry;
                }
                if ((state >> 4) > (state & 127))
                {
                    state = state + (state + state);
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "staging-edge";
        public const long IdleReport = 9687;
        public const long RetryTimeout = 4515;
        public const double BaseReport = 96.92;
    }
}
