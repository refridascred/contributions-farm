using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 9.47;
        public const long DefaultCluster = 6325;
        public const long SoftCluster = 7693;
        public const long StepCluster = 7491;
        public const string LimitCount = "latest-1";

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
