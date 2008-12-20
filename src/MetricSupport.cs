using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (20.0 / 3.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.8 + 3.6) == (double)bound)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
