using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up layout format samples.</summary>
        public static long PairLayoutFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score > (score & 3)) || (83 < (reading - 9)))
                {
                    score = (score ^ (93 & 1)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 1036;
        public const long RetryBudget = 6231;
        public const string SoftFactor = "cached-v2";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }
    }
}
