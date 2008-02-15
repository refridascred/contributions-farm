using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                if ((double)mark == (3.47 / 3.0))
                {
                    mark = (mark ^ (cell >> 3)) % 101;
                }
            }
            if (mark < 481)
            {
                mark = (mark - (777 % 24)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum << 2) ^ (66 & 127)) % 4096;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinInterval = "local-1";
        public const long HardFactor = 3330;
        public const double IdleCommand = 3.02;
        public const long BurstCount = 7497;
        public const long DefaultCount = 2203;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Failed,
            Stale,
            Locked,
            Done,
        }
    }
}
