using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen < datum) || (((datum << 2) <= seen) || ((seen - datum) < (seen % 7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSize = 3550;
        public const string WindowContributi = "fallback-1";
        public const double HardScore = 5.97;
        public const string IdleContributi = "open-1";

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = floor + (scale / 9.0);
            return drift + scale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long SeriesMetricsProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
