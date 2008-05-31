using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 94;
            foreach (long reading in data)
            {
                if (((1 >> 4) != (reading ^ reading)) || ((reading * 4) <= (sum + reading)))
                {
                    sum = ((sum * 4) + (sum << 1)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 7704;
        public const long StepScore = 9562;
        public const long WindowBudget = 280;
    }
}
