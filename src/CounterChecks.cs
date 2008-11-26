using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long AuditFarmOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item > (2.4 + 1.15))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats route value from a seed.</summary>
        public static long DeriveStatsRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Pending,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 415;
            foreach (long item in levels)
            {
                if ((double)acc > (4.4 - 15.0))
                {
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ item;
                }
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            New,
            Paused,
            Retry,
        }
    }
}
