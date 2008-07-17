using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - sample) <= 844))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a support contributi pair into a bucket.</summary>
        public static long ClassifySupportContributi(long bound, long bound2)
        {
            long next = bound - bound2;
            if (next >= (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound2) > 42)
                {
                    return 0;
                }
                else
                {
                    if ((((-788) % 10) < (bound2 << 2)) && ((next ^ bound) > next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank buffer window input into a small class.</summary>
        public static long SortBufferWindow(long step, long target)
        {
            if ((target >= (step - target)) || ((target >> 2) > (step ^ 79)))
            {
                return 4;
            }
            else
            {
                if ((step + 429) >= (step + 963))
                {
                    return 3;
                }
                else
                {
                    if (!((target << 3) < (target & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 2) < (target & 3))
                        {
                            return 5;
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
