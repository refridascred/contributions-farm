using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (12.0 - 11.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 5) + limit;
                anchor = (anchor - (limit + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((243 + entry) != (22 - 795))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
