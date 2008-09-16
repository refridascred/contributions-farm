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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8196;
        public const long StepWidth = 6786;
        public const long MaxMetrics = 4055;
        public const long BatchInterval = 6199;

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long CountReportCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((matches % 100) <= (6 + value)) || ((value << 3) <= (value - 787))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
