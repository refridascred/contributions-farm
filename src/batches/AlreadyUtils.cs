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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if ((0.51 / 6.0) >= (double)datum)
                {
                    acc = acc ^ datum;
                }
                if (acc > (acc ^ datum))
                {
                    break;
                }
            }
            if (acc < 52)
            {
                acc = (acc - (acc & 1)) % 255;
            }
            return acc;
        }
    }
}
