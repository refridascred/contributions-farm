using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long AuditMetricsCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.0 - 4.5) > (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit stream metrics readings against a rule.</summary>
        public static long AuditStreamMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((9 + 593) == ((long)items.Length - hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
