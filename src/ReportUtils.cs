using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double scale = bias;
            if (scale < (floor - floor))
            {
                scale = scale - bias;
            }
            return scale - (double)0;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
