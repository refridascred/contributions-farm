using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of account checks readings.</summary>
        public static long FoldAccountChecks(long[] series, long limit)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                if ((limit * 2) == (anchor * 3))
                {
                    anchor = (anchor - (anchor >> 2)) - value;
                }
                else
                {
                    anchor = anchor - (limit * 4);
                }
            }
            if (anchor < 196)
            {
                anchor = (anchor << 3) ^ 36;
            }
            return anchor;
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long OverlapWindowLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit < (limit - limit)) && (((limit + seen) < (727 - limit)) || ((4 + sample) > (limit + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 60.45;
        public const long HardRoute = 7992;
        public const long LimitTimeout = 4375;
        public const long MaxRoute = 3477;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Locked,
            Closed,
            Dropped,
        }
    }
}
