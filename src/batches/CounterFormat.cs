using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 4661;
        public const string BatchAccount = "legacy";
        public const long LimitCount = 9680;
        public const long SoftAccount = 71;
        public const long MinAccount = 8796;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long mark = 65;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (mark + sample))
                {
                    mark = (mark - (sample + sample)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long step)
        {
            if (!((double)step >= (17.0 + 8.0)))
            {
                return 1;
            }
            else
            {
                if ((step - floor) != (743 / 4))
                {
                    return 6;
                }
                else
                {
                    if ((6.38 - 4.5) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - floor) > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
