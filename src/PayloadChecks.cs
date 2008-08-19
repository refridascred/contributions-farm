using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long FindFormatWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((62 - matches) == (entry - matches)) || ((entry << 1) >= matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Retry,
            Closed,
        }
    }
}
