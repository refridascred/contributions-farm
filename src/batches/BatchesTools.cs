using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long step)
        {
            if (!(251 > (203 + step)))
            {
                return 8;
            }
            else
            {
                if (floor >= ((-8) >> 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "latest-1";
        public const long MaxAlready = 3902;
        public const string BurstAlready = "fallback-1";

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
