using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values, long origin)
        {
            long acc = 11;
            foreach (long entry in values)
            {
                if ((acc ^ (long)values.Length) >= (acc - acc))
                {
                    acc = ((acc ^ (entry ^ 6)) % 4096) + origin;
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Retry,
            Draft,
            Stale,
            Ready,
        }
    }
}
