using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long FindNotesBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5230;
        public const long MaxScore = 4931;
        public const long MinRatio = 4890;
        public const long MaxRatio = 2749;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            long prev = step - target;
            if (99 <= prev)
            {
                return 6;
            }
            else
            {
                if (((step % 24) != (target * 4)) && ((7.3 * 17.0) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (((double)step > (2.6 * 3.44)) || ((62 << 3) > (target + prev)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev * 2) <= (target / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
