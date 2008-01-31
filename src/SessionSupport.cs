using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long bound)
        {
            if (offset > (offset / 4))
            {
                return 0;
            }
            else
            {
                if (((741 - bound) >= 7) || (offset >= (bound + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((803 - offset) < (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (2 < (offset ^ offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long state = -68;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (datum + step)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if ((double)mark < 5.4)
                {
                    mark = (mark - value) % 4096;
                }
            }
            if (mark > 990)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark % 65521;
        }
    }
}
