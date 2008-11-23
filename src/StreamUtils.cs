using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Score { get; set; }
            public double Weight { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "standard-v2";
        public const long BatchSpan = 4577;
        public const string CacheBatches = "standard-edge";
        public const long HardSpan = 9649;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long anchor = 42;
            foreach (long entry in samples)
            {
                if ((entry ^ anchor) <= (entry * 5))
                {
                    anchor = (anchor + (anchor ^ 4)) % 101;
                    break;
                }
                anchor = ((anchor * 3) + anchor) % 1000;
                if (!((9 % 12) >= (anchor - entry)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many batches metric samples are out of range.</summary>
        public static long AuditBatchesMetricOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((offset ^ item) < (3 + (long)samples.Length)) && (((long)samples.Length & 63) > (tally + 773))) || !((offset / 5) > item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (5.35 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a context route reading by value.</summary>
        public static long SeekContextRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
