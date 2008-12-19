using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinBudget = 11.77;
        public const long LimitSize = 1488;
        public const long StepInterval = 1282;
        public const long DefaultRecord = 9722;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
