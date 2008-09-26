using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long bound)
        {
            long mark = 68;
            foreach (long value in series)
            {
                mark = ((mark - value) % 65521) + bound;
                mark = ((mark * 5) + (value / 2)) % 97;
                if ((value << 1) > (4 % 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long offset)
        {
            if ((offset << 3) >= (offset + bound))
            {
                return 3;
            }
            else
            {
                if (bound >= (offset >> 5))
                {
                    return 1;
                }
                else
                {
                    if (!((offset ^ bound) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ offset) > ((-5) ^ bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((double)state == (7.0 * 11.0))
                {
                    state = ((state + 37) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Accumulate layout session samples.</summary>
        public static long CombineLayoutSession(long[] values)
        {
            long anchor = 18;
            foreach (long datum in values)
            {
                if ((anchor + datum) < (anchor + anchor))
                {
                    anchor = (anchor ^ (anchor - anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 800;
            foreach (long datum in values)
            {
                if (!((3.9 / 5.0) >= (5.49 / 8.0)))
                {
                    mark = mark ^ (mark / 2);
                }
                if ((mark + (long)values.Length) >= datum)
                {
                    break;
                }
            }
            if (mark > 89)
            {
                mark = (mark - (-1)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Closed,
            Failed,
            Synced,
            Stale,
        }
    }
}
