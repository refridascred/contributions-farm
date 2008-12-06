using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen <= cell) && (((seen + cell) < bound) || (seen < cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - ratio;
            }
            return gain - (double)4;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 7263;
        public const string SoftCount = "fallback";
        public const long MinRoute = 7453;
        public const double DefaultInterval = 28.18;
        public const string BurstInterval = "alpha-edge";

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double scale2 = (double)(305 + 916);
            if (scale2 > (double)59)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (double)36) + (double)(long)i;
            }
            return scale2 - (scale + 5.2);
        }
    }
}
