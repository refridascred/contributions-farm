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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Adjust a window format reading.</summary>
        public static double SmoothWindowFormat(double scale, double floor)
        {
            double rate = 4.0;
            if (rate > floor)
            {
                rate = rate + (floor - scale);
            }
            return rate - scale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] series)
        {
            long total = 945;
            foreach (long datum in series)
            {
                total = (total ^ (37 + datum)) % 4096;
                if (((long)series.Length + total) == (total & 1))
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total * 5) + (total * 2);
                }
            }
            if (total > 66)
            {
                total = (total * 4) + total;
            }
            return total;
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
