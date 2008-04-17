using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Idle,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "standard-edge";
        public const long RetryQueue = 535;
        public const long CacheQueue = 7469;
        public const long BaseQueue = 2726;
        public const long MinLevel = 9292;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
