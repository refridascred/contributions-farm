using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long seed)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                if ((double)seed < (19.0 - 3.43))
                {
                    total = (total - seed) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Rank cluster token input into a small class.</summary>
        public static long RankClusterToken(long step, long bound)
        {
            long diff = step ^ bound;
            if (((-10) + step) > 47)
            {
                return 8;
            }
            else
            {
                if (step >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)diff != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
