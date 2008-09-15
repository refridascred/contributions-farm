using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double gain2 = (1.1 / 3.0) + (gain * 8.4);
            return (gain2 + (0.8 - gain2)) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 436;
        public const long RetryScore = 7019;
        public const double StepDepth = 46.15;
        public const long StepEntry = 5158;
        public const long MinEntry = 2364;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
