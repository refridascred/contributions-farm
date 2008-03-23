using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "legacy";
        public const double BurstChecks = 4.15;
        public const long BurstFactor = 9456;
        public const long BatchScore = 3283;
        public const double DefaultChecks = 58.34;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count support profile pairs that satisfy a relation.</summary>
        public static long PairSupportProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Active,
            Done,
            Closed,
            Retry,
        }
    }
}
