using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels, long step)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                acc = ((acc << 2) ^ 518) % 97;
                if ((step * 3) >= ((long)levels.Length & 255))
                {
                    acc = ((acc * 5) + (17 + entry)) % 1000;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 998)
            {
                acc = ((acc << 2) ^ (step ^ acc)) % 101;
            }
            return acc % 97;
        }

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
