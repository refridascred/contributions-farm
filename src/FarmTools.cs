using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 3364;
        public const long BurstReport = 8924;
        public const long IdleReport = 8670;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of editor queue readings.</summary>
        public static long TallyEditorQueue(long[] levels, long floor)
        {
            long acc = 276;
            foreach (long sample in levels)
            {
                acc = ((acc << 2) ^ (sample % 12)) - floor;
            }
            return acc % 65521;
        }
    }
}
