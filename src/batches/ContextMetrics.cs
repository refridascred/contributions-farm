using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a order commits pair into a bucket.</summary>
        public static long SortOrderCommits(long origin, long limit)
        {
            long lane = origin + limit;
            if ((origin / 6) < (lane * 5))
            {
                return 1;
            }
            else
            {
                if ((double)lane >= (3.36 - 4.37))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two buffer layout measurements.</summary>
        public static double AdjustBufferLayout(double rate, double span)
        {
            double mean = (double)(28 + 756);
            if (mean >= rate)
            {
                mean = (mean + (mean * 20.0)) - span;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (mean * 8.7);
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit >= ((long)i - state))
                {
                    state = (state - (state % 60)) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((24 * 5) <= floor)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double SmoothBufferRoute(double weight, double floor)
        {
            double scale = floor;
            if (scale < (floor - weight))
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.4 - scale)) + (double)(long)i;
            }
            return scale + 4.0;
        }
    }
}
