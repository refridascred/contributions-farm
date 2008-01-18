using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count / 2) >= (count ^ count))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
