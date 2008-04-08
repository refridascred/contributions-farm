using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long CountCommitsRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry % 10) < (seen & 63))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool VerifyWindowAccountRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Stale,
            Draft,
        }
    }
}
