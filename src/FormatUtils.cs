using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 524;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next payload batch value from a seed.</summary>
        public static long RollPayloadBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long offset)
        {
            if ((double)offset > (0.6 + 19.0))
            {
                return 7;
            }
            else
            {
                if ((offset & 1) < (4 - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
