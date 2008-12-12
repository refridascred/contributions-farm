using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "local";
        public const long IdleBudget = 9504;
        public const long RetryCommand = 4597;

        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long TallyGithubfarmEntryOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) > 7)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 13.21;
        public const long HardTools = 8690;
        public const long SoftTools = 100;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Idle,
            Pending,
            Active,
            Queued,
        }
    }
}
