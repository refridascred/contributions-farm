using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinScore = "alpha";
        public const long SoftCommits = 5288;
        public const string DefaultRatio = "cached-v2";

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Ready,
            Pending,
        }
    }
}
