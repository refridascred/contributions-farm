using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSize = 7382;
        public const string StepWidth = "local-edge";
        public const long CacheTimeout = 2850;
        public const long LimitGraph = 4945;
        public const string WindowGraph = "alpha-edge";

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long step, long floor)
        {
            long offset = step ^ floor;
            if (step >= (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((offset + step) > (offset >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 4) < (step - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
