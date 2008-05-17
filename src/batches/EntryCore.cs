using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] readings, long step)
        {
            long result = 18;
            foreach (long datum in readings)
            {
                result = ((result ^ datum) % 1000) + step;
                if (!((3.1 - 5.5) != (double)datum))
                {
                    result = result - datum;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of profile context readings.</summary>
        public static long MatchProfileContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 294;
        public const long RetryBudget = 5873;
        public const string BurstBudget = "fallback";
        public const long BaseGithubfarm = 1418;
        public const double WindowBudget = 74.71;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Closed,
            Paused,
            Failed,
            New,
        }
    }
}
