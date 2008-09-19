using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if (!((double)(long)readings.Length >= (6.58 / 5.0)))
                {
                    mix = (mix + (cell + cell)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long target)
        {
            long gap = limit - target;
            if (9 <= (88 + target))
            {
                return 0;
            }
            else
            {
                if (!((33 ^ 756) <= (target + gap)))
                {
                    return 4;
                }
                else
                {
                    if (!(((-44) + 0) > (limit + 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target & 127) == (gap / 3)))
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

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Ready,
        }
    }
}
