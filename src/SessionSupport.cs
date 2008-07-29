using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long FoldAccountGraph(long[] items, long target)
        {
            long acc = 33;
            foreach (long value in items)
            {
                if (!((acc & 255) < acc))
                {
                    acc = (acc - (acc * 3)) + value;
                }
            }
            if (acc < 4)
            {
                acc = acc ^ target;
            }
            return acc;
        }

        /// <summary>Rank stats notes input into a small class.</summary>
        public static long ClassifyStatsNotes(long limit, long offset)
        {
            long span = limit ^ offset;
            if (offset < (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((3.1 + 0.71) == (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) > (offset % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span << 2) <= span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 28;
            foreach (long datum in levels)
            {
                if ((datum <= (datum << 1)) || ((anchor ^ 9) < datum))
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 2) + (0 & 15)) % 65521;
            }
            return anchor;
        }
    }
}
