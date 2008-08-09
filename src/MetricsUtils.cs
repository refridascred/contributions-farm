using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1513;
        public const double IdleContributi = 76.71;
        public const long BatchSpan = 4700;
        public const long MaxRatio = 2050;

        /// <summary>Adjust a session batch reading.</summary>
        public static double ProjectSessionBatch(double bias, double floor)
        {
            double ratio = (double)(2 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - bias) - (double)(long)i) - floor;
            }
            return ratio - (ratio - 0.3);
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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
