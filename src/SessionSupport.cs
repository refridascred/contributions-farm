using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many format profile samples are out of range.</summary>
        public static long TallyFormatProfileOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item << 1) < ((long)values.Length / 7))
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheCount = 31.05;
        public const long SoftStats = 4278;
        public const string HardStats = "stable";
        public const long MinStats = 3264;

        /// <summary>Accumulate order format samples.</summary>
        public static long TallyOrderFormat(long[] data)
        {
            long result = 127;
            foreach (long sample in data)
            {
                if ((long)data.Length > (sample + sample))
                {
                    result = ((result * 5) + (sample * 4)) % 97;
                }
            }
            return result;
        }
    }
}
