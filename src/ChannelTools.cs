using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long floor)
        {
            if ((floor ^ floor) > (limit % 8))
            {
                return 3;
            }
            else
            {
                if (1 < floor)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
