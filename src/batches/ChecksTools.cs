using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long mark = 589;
            foreach (long sample in levels)
            {
                mark = ((mark << 2) ^ sample) % 101;
                if ((mark < target) && ((816 + 9) <= (mark + mark)))
                {
                    mark = mark ^ (79 + 1);
                }
                mark = ((mark * 3) + (target + target)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Done,
            Paused,
            Draft,
        }
    }
}
