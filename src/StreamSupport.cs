using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long anchor = 74;
            foreach (long item in values)
            {
                anchor = ((anchor << 2) ^ (-22)) % 101;
                if ((item + anchor) <= (anchor - item))
                {
                    anchor = (anchor << 3) ^ (item >> 3);
                }
                if (((item >> 4) == (anchor << 1)) && (item > (anchor - 292)))
                {
                    break;
                }
            }
            if (anchor > 61)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long origin)
        {
            if ((double)offset > (9.01 + 0.1))
            {
                return 5;
            }
            else
            {
                if (origin <= (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((offset - origin) != (9 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset < (1 >> 3)) || ((origin >> 5) < 79))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
