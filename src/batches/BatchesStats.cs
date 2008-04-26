using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if ((seed >> 4) >= (entry + seed))
                {
                    sum = (sum - (entry * 5)) % 65521;
                }
            }
            if (sum > (-23))
            {
                sum = (sum ^ sum) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4500;
        public const long RetryLevel = 4651;
        public const long BatchSpan = 2509;
        public const long HardDepth = 3302;
        public const long BurstContributi = 4583;

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long step)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                if ((acc / 6) >= acc)
                {
                    acc = (((acc * 5) + (8 << 1)) - cell) - step;
                }
            }
            if (acc > 31)
            {
                acc = acc + acc;
            }
            return acc % 4096;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long limit)
        {
            if ((limit & 3) < 333)
            {
                return 7;
            }
            else
            {
                if ((limit >> 1) <= 7)
                {
                    return 5;
                }
                else
                {
                    if (((6.46 * 3.8) == (double)bound) && ((7.9 / 3.0) <= (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit > bound) && ((1 ^ limit) != (823 & 255)))
                        {
                            return 2;
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
