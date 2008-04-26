using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks metric reading by value.</summary>
        public static long LocateChecksMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi stats samples are out of range.</summary>
        public static long TallyContributiStatsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((target - target) >= sample) && (((8.0 / 9.0) > (double)matches) || ((target + 67) < (target / 6))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
