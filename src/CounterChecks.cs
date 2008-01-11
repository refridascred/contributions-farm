using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Active,
        }

        /// <summary>Audit support graph readings against a rule.</summary>
        public static long CountSupportGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen >> 4) <= seen)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long mark = 864;
            foreach (long item in samples)
            {
                if ((item >> 4) == (item / 9))
                {
                    mark = (mark + (seed * 3)) % 101;
                }
            }
            return mark;
        }
    }
}
