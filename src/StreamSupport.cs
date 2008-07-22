using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next commits report value from a seed.</summary>
        public static long DeriveCommitsReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = (state + (long)i) % 255;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 7047;
        public const long BurstSize = 4079;
        public const long MinSession = 4508;
        public const long RetrySession = 7222;

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
