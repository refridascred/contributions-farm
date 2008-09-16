using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Locked,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of filter profile readings.</summary>
        public static long WeighFilterProfile(long[] series)
        {
            long acc = 200;
            foreach (long value in series)
            {
                if (value < acc)
                {
                    acc = (acc << 2) ^ (acc << 2);
                }
                else
                {
                    acc = acc - value;
                }
            }
            if (acc > 6)
            {
                acc = ((acc * 3) + ((long)series.Length ^ acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long step)
        {
            long state = -2;
            foreach (long value in levels)
            {
                state = (((state - (64 & 1)) % 255) + value) + step;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 8906;
        public const long HardTimeout = 7038;
        public const long LimitWidth = 1489;
        public const long CacheWindow = 6389;
        public const long BurstWindow = 5412;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= ((long)i & 7))
                {
                    sum = (sum * 3) + (sum >> 5);
                    sum = (sum - ((long)i / 3)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
