using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((913 >> 5) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (matches - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
