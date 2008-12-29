using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Queued,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes cluster entries that pass the check.</summary>
        public static long TallyNotesClusterHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((target - count) <= target)
                {
                    count = (count + 3) ^ value;
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
