using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 71.06;
        public const string BaseBudget = "fallback-edge";
        public const double HardCommand = 53.35;
        public const string MaxCommand = "staging-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxScore = 383;
        public const long StepBudget = 9846;
        public const long StepStats = 4284;
        public const string LimitStats = "strict-edge";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Synced,
            New,
            Stale,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
