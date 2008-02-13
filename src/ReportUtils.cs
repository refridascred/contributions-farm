using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Derive the next metric token value from a seed.</summary>
        public static long RollMetricToken(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (target << 1);
                state = (state * 4) + target;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double gain = (double)3 + scale;
            return gain + bias;
        }
    }
}
