using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context report series from a seed.</summary>
        public static long IterateContextReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long floor)
        {
            if ((floor ^ floor) >= 40)
            {
                return 0;
            }
            else
            {
                if ((origin & 1) >= (floor + origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many route record samples are out of range.</summary>
        public static long TallyRouteRecordHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (7.0 + 5.5))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
