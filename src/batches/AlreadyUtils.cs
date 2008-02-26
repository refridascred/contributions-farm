using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 519;
        public const string DefaultQueue = "standard-1";
        public const long BatchQueue = 2821;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ (bound ^ carry)) % 1000) ^ (long)i2;
                }
                carry = ((carry << 2) ^ (carry / 7)) % 1000;
                carry = (carry - ((long)i + carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ (score - 37);
                score = score ^ (587 - limit);
                score = (score ^ (limit - limit)) % 255;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count window already pairs that satisfy a relation.</summary>
        public static long MatchWindowAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev + limit) < (limit << 3))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (2.04 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 12) == (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + limit) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
