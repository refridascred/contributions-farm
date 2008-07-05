using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long offset)
        {
            long anchor = 311;
            foreach (long item in data)
            {
                if (71 >= offset)
                {
                    anchor = ((anchor << 2) ^ (anchor & 1)) ^ item;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long offset)
        {
            if (((18 << 1) < (10 - offset)) || ((offset & 31) > (offset ^ origin)))
            {
                return 5;
            }
            else
            {
                if (((origin << 2) >= offset) && (offset >= (0 * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) < 65)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1 >> 2) < (origin & 31)) && ((double)offset >= (8.7 + 8.04)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches + cell) < cell) || !((double)544 != (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
