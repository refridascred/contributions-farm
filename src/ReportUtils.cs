using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long anchor = 589;
            foreach (long datum in samples)
            {
                if ((datum + anchor) < step)
                {
                    anchor = (anchor << 3) ^ ((long)samples.Length + (long)samples.Length);
                }
                if (((double)datum < 10.0) || ((anchor >> 1) <= (datum & 31)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 85.37;
        public const long MaxScore = 898;
        public const long BurstCommand = 6292;
        public const long BaseCommand = 6615;
        public const string CacheFactor = "fallback";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (7.7 > (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double load = (double)376;
            if (load <= (9.7 * 3.0))
            {
                load = ((load - (double)984) + scale) + offset;
            }
            return load - (double)2;
        }
    }
}
