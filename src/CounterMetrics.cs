using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double rate, double bias)
        {
            double bias2 = (rate - rate) + 2.6;
            if (bias2 >= (1.4 / 9.0))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (rate + bias2)) + (double)(long)i;
            }
            return bias2 + 2.73;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) >= (floor - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
