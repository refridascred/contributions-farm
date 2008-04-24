using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long score = 9;
            foreach (long cell in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score - (score ^ score)) + (long)i;
                }
                if ((limit ^ cell) <= cell)
                {
                    score = score - (3 * 2);
                }
                if (score < (score & 127))
                {
                    score = (score + (limit >> 5)) % 4096;
                }
            }
            if (score > 0)
            {
                score = (score * 4) + (score + limit);
            }
            return score % 65521;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long floor)
        {
            if (target <= (target * 2))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) > (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if ((826 / 9) < (179 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + floor) == (target ^ floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2196;
        public const double SoftWidth = 45.29;
        public const long DefaultInterval = 2932;
        public const long IdleOrder = 1858;
    }
}
