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

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 3) ^ 576) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
