using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long bound)
        {
            if (bound < (seed * 4))
            {
                return 5;
            }
            else
            {
                if (1 > (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 3) <= (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long offset)
        {
            long span = origin + offset;
            if ((origin >> 4) != (span & 15))
            {
                return 8;
            }
            else
            {
                if ((span & 31) >= (span ^ offset))
                {
                    return 4;
                }
                else
                {
                    if (span > (offset + 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
