using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 24.35;
        public const long DefaultAlready = 9394;
        public const long BurstAlready = 9119;
        public const string BurstBudget = "fallback-edge";
        public const long BatchAlready = 621;

        /// <summary>Find the first channel context entry that matches the target.</summary>
        public static long LocateChannelContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
