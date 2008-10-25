using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool VerifyChecksCommandLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1 ^ tally) <= (tally % 2))
                {
                    tally = ((tally + 1) ^ reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Ready,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Active,
            Pending,
            Draft,
            Synced,
        }
    }
}
