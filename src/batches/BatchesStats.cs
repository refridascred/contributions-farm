using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up payload report samples.</summary>
        public static long PairPayloadReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((0 >> 4) <= (floor - step))
            {
                return 2;
            }
            else
            {
                if (75 <= (step >> 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long offset)
        {
            long next = limit + offset;
            if ((offset >> 5) == (789 - next))
            {
                return 1;
            }
            else
            {
                if ((offset >= 22) && ((double)offset < (double)next))
                {
                    return 4;
                }
                else
                {
                    if ((limit + offset) <= (offset - next))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < ((-34) << 3))
                        {
                            return 0;
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
