using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up order notes samples.</summary>
        public static long PairOrderNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 5911;
        public const long LimitLevel = 1876;
        public const string IdleSize = "latest-1";
        public const double BaseRatio = 4.29;
        public const long DefaultContext = 1247;

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 301;
        public const long BurstSize = 1469;
        public const long RetryLayout = 535;
        public const double CacheSize = 11.96;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ (step * 5);
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
