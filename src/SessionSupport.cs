using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6420;
        public const double BatchLevel = 51.53;
        public const long DefaultCommand = 6371;
        public const string StepCommand = "fallback";
        public const long LimitCommand = 6892;

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long RankCounterCommand(long seed, long origin)
        {
            if (3.0 < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin << 3) > (seed + 802))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of filter account readings.</summary>
        public static long CompareFilterAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
