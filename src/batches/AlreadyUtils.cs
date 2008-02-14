using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Synced,
            New,
            Closed,
            Queued,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5599;
        public const long WindowStats = 1106;
        public const string HardDepth = "fallback-1";
        public const long StepStats = 9112;
    }
}
