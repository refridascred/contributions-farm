using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] values, long target)
        {
            long score = 479;
            foreach (long datum in values)
            {
                if (!((target >> 5) > (33 + datum)))
                {
                    score = (score - (target + score)) % 65521;
                }
            }
            if (score > 19)
            {
                score = (score + target) % 4096;
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item + count) < (5 / 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double bias)
        {
            double scale = rate * 9.17;
            if (scale <= scale)
            {
                scale = (scale - (rate / 2.0)) - bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Derive the next route account value from a seed.</summary>
        public static long RollRouteAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= (result * 4))
                {
                    result = result + ((long)i << 1);
                }
                result = ((result << 3) ^ (93 + 6)) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
