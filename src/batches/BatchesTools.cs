using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long AuditContextStreamHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-625) - matches) >= matches)
                {
                    matches = ((matches + 1) - cell) + target;
                }
            }
            return matches;
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
