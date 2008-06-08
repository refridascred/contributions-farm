using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "stable-v2";
        public const long MinCount = 6935;
        public const string StepInterval = "local-1";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Look up the position of a already counter sample.</summary>
        public static long LocateAlreadyCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
