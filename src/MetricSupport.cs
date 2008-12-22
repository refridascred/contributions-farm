using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long score = 67;
            foreach (long datum in levels)
            {
                score = ((score * 2) + (datum + score)) % 97;
            }
            if (score > 22)
            {
                score = (score * 5) + seed;
            }
            return score;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
