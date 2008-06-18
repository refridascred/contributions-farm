using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a tools context reading by value.</summary>
        public static long LookupToolsContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading % 16))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
