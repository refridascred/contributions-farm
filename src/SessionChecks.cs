using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record stats entries.</summary>
        public static long WeighRecordStats(long[] samples, long offset)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                state = (((state << 2) ^ (state * 2)) + reading) + offset;
                state = (state - (78 >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 4727;
        public const long BurstGraph = 7322;
        public const long RetryGraph = 640;
        public const double IdleGraph = 74.87;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ ((long)i & 3)) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
