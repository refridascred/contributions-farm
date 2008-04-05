using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 5) > (reading + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long bound)
        {
            if (((4 << 2) < offset) || (8 > (offset >> 1)))
            {
                return 0;
            }
            else
            {
                if ((bound * 5) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate order account readings against a bound.</summary>
        public static bool VerifyOrderAccountBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
