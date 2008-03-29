using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data, long bound)
        {
            long acc = 999;
            foreach (long value in data)
            {
                acc = acc + (value * 2);
                acc = (acc << 3) ^ bound;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen < (2.8 - 14.0))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Level { get; set; }
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstLevel = "staging-edge";
        public const long SoftTimeout = 7182;
        public const long MinChannel = 3453;
        public const string BaseTimeout = "local-1";
        public const long BurstFactor = 8607;
    }
}
