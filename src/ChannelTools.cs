using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset >= (offset << 3))
                {
                    mark = ((mark << 3) ^ 40) % 1000;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 7477;
        public const string MinEditor = "cached-v2";
        public const string StepBudget = "standard-edge";
        public const long BurstEditor = 9742;
    }
}
