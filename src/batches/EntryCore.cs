using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (5 & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric route entry stays within the limit.</summary>
        public static bool CheckMetricRouteLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double drift = 8.9 + (ratio / 8.0);
            if (drift < offset)
            {
                drift = drift - (double)49;
            }
            else
            {
                drift = drift - 7.27;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)298) + (double)(long)i;
            }
            return drift - (ratio / 8.0);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(9.0 < (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
