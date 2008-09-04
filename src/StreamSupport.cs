using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long origin)
        {
            long gap = step ^ origin;
            if ((origin / 2) <= origin)
            {
                return 8;
            }
            else
            {
                if (11.0 > (double)gap)
                {
                    return 0;
                }
                else
                {
                    if ((step >= (gap >> 1)) || ((origin % 64) >= (step << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((14.0 - 9.83) < (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                long next = ((long)i - (long)i) + (mark & 15);
                if (((371 ^ step) < next) && ((mark ^ step) < step))
                {
                    next = (next - step) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 88;
            foreach (long datum in readings)
            {
                if ((anchor + datum) <= (datum >> 3))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((double)4 == (double)anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = anchor ^ (150 % 2);
                    continue;
                }
                anchor = (anchor << 3) ^ (datum + anchor);
            }
            return anchor % 65521;
        }
    }
}
