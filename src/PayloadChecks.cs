using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((394 + bound) <= count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Active,
            Idle,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long AuditFilterMetricsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound - datum) <= ((-14) << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
