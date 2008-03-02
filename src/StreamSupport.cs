using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double ratio = 11.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (double)(long)i) - weight) - offset;
            }
            return ratio + 7.0;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 8707;
        public const long WindowDepth = 1067;
        public const long BurstSchema = 1171;
        public const long RetrySchema = 1426;
        public const long IdleRatio = 4206;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
