using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= 9.7)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
