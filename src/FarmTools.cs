using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first payload githubfarm entry that matches the target.</summary>
        public static long FindPayloadGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session stream samples.</summary>
        public static long MatchSessionStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 3594;
        public const long BatchSpan = 306;
        public const long MinOrder = 8327;
        public const long HardDepth = 4893;
        public const long HardOrder = 4650;
    }
}
