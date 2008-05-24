using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long offset)
        {
            long span = seed + offset;
            if ((1.27 + 6.83) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((13 + offset) == (seed + 237))
                {
                    return 6;
                }
                else
                {
                    if (!(span < (offset - span)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - 21) == (165 + seed)) || ((seed - seed) != (seed ^ 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 70;
            foreach (long entry in samples)
            {
                carry = carry + entry;
                if ((double)carry == (double)entry)
                {
                    carry = carry ^ (81 + carry);
                }
                if (!((double)entry != (double)carry))
                {
                    break;
                }
            }
            if (carry > 128)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long MeasureContextSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen >= (cell << 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
