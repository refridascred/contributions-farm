using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double span)
        {
            double weight = 6.0 - ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + ratio) - (double)(long)i) - span;
            }
            return weight + (ratio + weight);
        }

        /// <summary>Measure how many report record samples are out of range.</summary>
        public static long CountReportRecordHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample <= (-92))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool ValidateMetricsChecksBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
