using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "strict";
        public const long WindowChecks = 4611;
        public const long MaxDepth = 2477;
        public const long HardFactor = 2014;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultScore = 7826;
        public const long BurstToken = 3439;
        public const long CacheToken = 5328;

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
