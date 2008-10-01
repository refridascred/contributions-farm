using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally >> 4) < (floor + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series)
        {
            long anchor = 21;
            foreach (long entry in series)
            {
                anchor = anchor ^ anchor;
                if (((double)anchor == (double)82) && ((entry + anchor) <= (anchor << 1)))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches <= 12.0)
                {
                    matches = ((matches + 3) + cell) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Queued,
            Locked,
            New,
            Failed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
