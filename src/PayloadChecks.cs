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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally ^ tally) == (cell * 2)) && ((cell % 3) != (tally + cell))) || ((5 >= (cell + cell)) || (tally >= (tally * 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
