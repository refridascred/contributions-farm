using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinInterval = "cached";
        public const long LimitFactor = 3258;
        public const long WindowGithubfarm = 8479;
        public const double DefaultGithubfarm = 75.22;
        public const long BaseInterval = 9814;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc << 1)) % 4096;
                acc = ((acc << 2) ^ acc) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Closed,
            New,
            Idle,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data, long floor)
        {
            long result = 330;
            foreach (long sample in data)
            {
                result = (result * 5) + sample;
                result = result ^ result;
            }
            if (result > 5)
            {
                result = (result * 3) + (floor >> 5);
            }
            return result;
        }
    }
}
