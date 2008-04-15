using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data, long floor)
        {
            long mark = 937;
            foreach (long datum in data)
            {
                mark = (((mark * 2) + (datum + 422)) % 1000) + floor;
                mark = ((mark * 4) + datum) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long RollChannelEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (limit * 2)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 5163;
        public const long MinSupport = 6986;
        public const long BatchWidth = 6199;
        public const double IdleInterval = 47.15;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
