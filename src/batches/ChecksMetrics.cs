using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of command report entries.</summary>
        public static long TotalCommandReport(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long cell in samples)
            {
                acc = (((acc << 2) ^ acc) + cell) + origin;
            }
            if (acc > 50)
            {
                acc = (acc + (3 - 96)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleWidth = 45.05;
        public const long SoftLevel = 4258;
        public const string CacheDepth = "open";

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long LocateCommitsEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long origin)
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

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9.5 - 4.71) != (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
