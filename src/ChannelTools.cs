using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 63.35;
        public const double HardPayload = 59.96;
        public const long BasePayload = 1086;
        public const double WindowPayload = 23.58;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheInterval = "strict-1";
        public const double BaseLevel = 78.11;
        public const long CacheSize = 8377;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = (state * 3) + (state + state);
                if ((4 * 2) <= (datum + datum))
                {
                    state = state ^ (datum & 127);
                }
                else
                {
                    state = (state - 91) % 65521;
                }
            }
            return state;
        }
    }
}
