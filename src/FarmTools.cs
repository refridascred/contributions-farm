using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 5897;
        public const long IdleSpan = 4641;
        public const long IdleAlready = 6261;
        public const long WindowAlready = 3227;
        public const string HardFactor = "open-v2";

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
