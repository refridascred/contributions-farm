using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 32.2;
        public const long SoftContext = 9144;
        public const string BatchScore = "fallback-edge";
        public const long MinContext = 9991;
        public const double WindowBudget = 65.9;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits - hits) != (entry / 5)) || ((8.26 - 4.0) == (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
