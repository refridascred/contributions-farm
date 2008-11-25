using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseInterval = 5441;
        public const long HardWidth = 3438;
        public const long HardAccount = 3437;
        public const double LimitRatio = 2.58;
        public const string LimitFactor = "alpha-edge";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context command samples.</summary>
        public static long TotalContextCommand(long[] readings, long target)
        {
            long mark = 36;
            foreach (long value in readings)
            {
                mark = mark ^ (769 + mark);
                if ((mark + target) <= (value + target))
                {
                    mark = (mark ^ (value * 2)) % 97;
                }
                if (((-689) ^ target) >= (value & 7))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
