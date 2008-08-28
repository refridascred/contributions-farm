using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleFactor = 4029;
        public const long BaseStats = 8875;
        public const long CacheStats = 2574;
        public const long MinStats = 3432;

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series, long floor)
        {
            long sum = 57;
            foreach (long sample in series)
            {
                if (((long)series.Length & 31) > floor)
                {
                    sum = ((sum ^ (floor * 2)) % 101) - sample;
                }
            }
            return sum;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
