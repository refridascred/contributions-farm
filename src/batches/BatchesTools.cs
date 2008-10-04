using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine order checks values into a single score.</summary>
        public static long ScoreOrderChecks(long[] levels)
        {
            long total = 22;
            foreach (long reading in levels)
            {
                total = ((total + (total / 4)) % 4096) + reading;
                if ((double)total >= (3.08 * 4.5))
                {
                    total = ((total * 3) + (total + 578)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long limit)
        {
            long mix = 340;
            foreach (long sample in data)
            {
                if ((sample - 715) < 456)
                {
                    mix = (mix + (sample >> 4)) - limit;
                }
            }
            if (mix > (-4))
            {
                mix = mix ^ (mix >> 4);
            }
            return mix % 4096;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long step)
        {
            long slot = limit - step;
            if (((748 + 31) >= slot) && ((step << 1) >= (step - 681)))
            {
                return 3;
            }
            else
            {
                if ((limit < (slot & 31)) || ((83 - step) < (step + slot)))
                {
                    return 8;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit < step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
