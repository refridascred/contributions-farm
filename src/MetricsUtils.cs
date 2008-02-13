using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftInterval = "cached-1";
        public const long DefaultScore = 8889;
        public const string BaseWidth = "cached-edge";
        public const long HardContext = 6733;
        public const string BurstRatio = "alpha";

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data)
        {
            long mix = 76;
            foreach (long item in data)
            {
                if (!(((-206) << 2) > (item ^ mix)))
                {
                    mix = (mix - ((-14) ^ mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 2) ^ (carry / 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((2 & 7) > (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if ((origin + 570) != (origin / 9))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (12.0 * 9.55))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Pending,
            Active,
        }
    }
}
