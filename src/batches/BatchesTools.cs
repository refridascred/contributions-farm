using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double drift = floor + (double)12;
            if (drift > (double)32)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift + (double)106;
            }
            return drift + (drift / 7.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 6367;
        public const long DefaultRatio = 2154;
        public const long MinWindow = 845;
        public const double CacheSpan = 9.57;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) > entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
