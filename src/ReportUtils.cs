using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "local-edge";
        public const long MinTimeout = 9892;
        public const long IdleCommand = 8492;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Paused,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (6.7 >= (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double bias = (double)(446 - 6);
            if (bias < scale)
            {
                bias = bias + (span / 6.0);
            }
            else
            {
                bias = bias + (span * 4.6);
            }
            return bias - 6.6;
        }
    }
}
