using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long MeasureProfileCommandGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8 + tally) > (reading - 2))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double ratio = (3.0 + 0.4) / 8.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (double)147) + (double)(long)i) - span;
            }
            return ratio - rate;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "staging-1";
        public const string CacheWidth = "open-edge";
        public const string WindowBudget = "fallback-edge";
        public const long BurstGraph = 6842;
    }
}
