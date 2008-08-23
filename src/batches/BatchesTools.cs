using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 486;
        public const long SoftCommits = 5073;
        public const long LimitCommits = 7222;
        public const string BurstCommits = "alpha-v2";
        public const long BatchCount = 415;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((step / 4) > 9)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
