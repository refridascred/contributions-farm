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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long offset)
        {
            long slot = step - offset;
            if ((double)offset > (9.86 / 4.0))
            {
                return 1;
            }
            else
            {
                if ((slot + 26) == (offset * 4))
                {
                    return 0;
                }
                else
                {
                    if ((slot ^ slot) > (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 7704;
        public const long StepScore = 9562;
        public const long WindowBudget = 280;
    }
}
