using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum >= (step + 33))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token report readings.</summary>
        public static long TotalTokenReport(long[] items, long target)
        {
            long acc = 2;
            foreach (long item in items)
            {
                if (target >= (67 + target))
                {
                    acc = (acc - target) - item;
                }
            }
            if (acc < 5)
            {
                acc = acc - (target + target);
            }
            return acc;
        }
    }
}
