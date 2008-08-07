using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Done,
            Paused,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 8.36;
        public const long MinTimeout = 6634;
        public const string DefaultTimeout = "cached-1";
        public const long StepDepth = 6077;

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long CompareWindowFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
