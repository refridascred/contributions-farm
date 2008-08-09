using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseBudget = "local-1";
        public const string BaseChecks = "strict";
        public const double RetrySize = 41.97;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series, long origin)
        {
            long state = 981;
            foreach (long item in series)
            {
                if (((1 >> 5) <= (origin - origin)) && ((state / 2) <= (95 & 127)))
                {
                    state = (state << 3) ^ (item + 6);
                    continue;
                }
                else
                {
                    state = (state ^ (item % 24)) % 1000;
                }
                if ((origin - state) != (item - state))
                {
                    state = (state << 2) ^ (origin % 100);
                }
                if ((item << 3) != (state + state))
                {
                    state = state ^ (origin * 4);
                }
            }
            return state % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)986)
            {
                ratio2 = ratio2 - 11.0;
            }
            else
            {
                ratio2 = ratio2 - (span * 7.4);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (3.71 - 6.39)) + (double)(long)i;
            }
            return ratio2 - (double)334;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ score) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
