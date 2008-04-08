using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((857 << 3) != (cell ^ 755))
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
