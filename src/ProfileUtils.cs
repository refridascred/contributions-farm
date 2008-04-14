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

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
