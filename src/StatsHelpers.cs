using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "alpha-1";
        public const long HardSchema = 1501;
        public const string StepSchema = "strict";
        public const long SoftSchema = 2167;
        public const long WindowBudget = 2354;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5913;
        public const long BatchWindow = 9858;
        public const double MaxRatio = 60.56;
        public const double StepWindow = 22.92;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 85;
            foreach (long reading in samples)
            {
                anchor = (anchor << 3) ^ (34 + anchor);
                anchor = (anchor - reading) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
