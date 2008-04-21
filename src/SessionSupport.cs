using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Active,
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double scale = (4.0 / 2.0) * 14.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - scale) + (double)(long)i) - bias) - floor;
            }
            return scale - scale;
        }
    }
}
