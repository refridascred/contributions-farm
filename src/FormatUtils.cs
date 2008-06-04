using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report context readings against a bound.</summary>
        public static bool CheckReportContextRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3341;
        public const double DefaultWidth = 0.15;
        public const string DefaultNotes = "latest-edge";
        public const double MinNotes = 31.32;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Active,
            Queued,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double load = (double)(607 - 46);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + bias) - (double)(long)i) - bias2;
            }
            return load - (double)89;
        }
    }
}
