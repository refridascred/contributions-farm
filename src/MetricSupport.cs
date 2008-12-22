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

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long bound)
        {
            long state = 343;
            foreach (long cell in samples)
            {
                if (((bound << 1) <= state) || ((cell ^ bound) == (bound + cell)))
                {
                    state = (state - (cell & 63)) % 4096;
                }
            }
            return state % 65521;
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
