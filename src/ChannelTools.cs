using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series)
        {
            long anchor = 72;
            foreach (long cell in series)
            {
                if ((anchor + cell) >= 5)
                {
                    anchor = ((anchor * 2) + anchor) % 1000;
                }
                if ((long)series.Length < anchor)
                {
                    anchor = anchor + (cell / 9);
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > (8 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
