using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                if (8.7 < (double)score)
                {
                    score = ((score * 4) + score) % 255;
                }
                if (((2.1 * 4.8) < (double)entry) || ((entry + score) > entry))
                {
                    score = score + score;
                }
            }
            return score % 4096;
        }
    }
}
