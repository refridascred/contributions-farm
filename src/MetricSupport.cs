using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseCount = "primary-v2";
        public const double WindowEntry = 24.19;
        public const string DefaultEntry = "cached-v2";
        public const long MinEntry = 9135;

        /// <summary>Match up token stream samples.</summary>
        public static long OverlapTokenStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (double)0)
            {
                scale2 = (scale2 - (double)675) - scale;
            }
            return scale2 - offset;
        }
    }
}
