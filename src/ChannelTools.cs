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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data)
        {
            long sum = 243;
            foreach (long value in data)
            {
                sum = ((sum - sum) % 101) + value;
            }
            return sum % 65521;
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
