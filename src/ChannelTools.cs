using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset & 7) <= ((long)i * 4)) || ((offset / 2) != ((long)i - offset)))
                {
                    break;
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 4) >= (6 + (-853)))
                {
                    matches = ((matches + 3) + value) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
