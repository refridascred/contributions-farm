using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 4355;
        public const string RetryDepth = "stable-1";
        public const long DefaultFarm = 2324;

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (9.19 <= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
