using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((44 + (long)i) != ((long)i >> 4))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long target)
        {
            long acc = 757;
            foreach (long cell in values)
            {
                if ((double)acc > 4.5)
                {
                    acc = (((acc << 2) ^ (acc << 2)) + cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long bound)
        {
            long edge = limit + bound;
            if (edge < (bound << 3))
            {
                return 3;
            }
            else
            {
                if (((870 + 65) <= (limit + edge)) || (8 > limit))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (621 - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5.4 > (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + (long)i) <= (long)i) && ((15.0 * 3.6) >= (double)state))
                {
                    state = ((state << 3) ^ (limit - 5)) % 101;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (30 >> 2)) % 4096) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long target)
        {
            long carry = 53;
            foreach (long datum in items)
            {
                if (((double)datum >= 6.61) || ((2 + carry) >= (datum >> 2)))
                {
                    carry = (carry * 5) + target;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum + 6)) % 4096;
                }
            }
            return carry;
        }
    }
}
