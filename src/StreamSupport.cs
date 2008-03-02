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

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double bias2 = 1.0 - scale;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - (double)661) + (double)(long)i) - bias;
            }
            return bias2 - scale;
        }

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
