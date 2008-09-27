using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (datum / 8)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
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

        /// <summary>Derive the next schema notes value from a seed.</summary>
        public static long SeriesSchemaNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + step) % 255;
                mix = mix - step;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
