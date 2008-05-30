using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits >> 5) >= 5)
                {
                    hits = ((hits + 1) ^ datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a githubfarm layout reading by value.</summary>
        public static long FindGithubfarmLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
