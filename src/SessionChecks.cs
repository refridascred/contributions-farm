using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 4800;
        public const long DefaultFactor = 7427;
        public const long SoftAlready = 7720;
        public const long BaseSize = 9897;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2826;
        public const string BatchCache = "latest-v2";
        public const long BurstCache = 73;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Done,
            Paused,
            Active,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result * 2) + ((long)i - offset);
                result = (result ^ (56 / 9)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
