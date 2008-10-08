using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length + offset) == (seen % 10)) || (((double)datum <= (double)offset) && ((offset + 45) >= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
