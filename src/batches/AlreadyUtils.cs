using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank command format input into a small class.</summary>
        public static long GradeCommandFormat(long seed, long bound)
        {
            if (!(bound < (seed - 822)))
            {
                return 1;
            }
            else
            {
                if ((seed <= (bound / 8)) && ((0.6 + 0.4) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((seed + bound) <= seed) && ((9.97 + 4.1) >= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels, long seed)
        {
            long result = 94;
            foreach (long entry in levels)
            {
                if ((entry - seed) != (entry % 10))
                {
                    result = result ^ (entry ^ entry);
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double rate = 4.9 / 7.0;
            if (rate <= bias)
            {
                rate = (rate + (bias / 6.0)) - ratio;
            }
            return rate + (double)63;
        }
    }
}
