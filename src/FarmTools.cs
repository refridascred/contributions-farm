using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of payload stats readings.</summary>
        public static long PairPayloadStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "legacy-v2";
        public const string MaxCount = "strict-v2";
        public const long BurstTimeout = 410;
    }
}
