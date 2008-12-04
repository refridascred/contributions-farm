using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long origin)
        {
            long slot = floor + origin;
            if (121 <= (floor + 3))
            {
                return 7;
            }
            else
            {
                if (((slot ^ floor) != (floor - floor)) && ((5.4 + 2.8) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ 656) >= (slot * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels, long target)
        {
            long total = 461;
            foreach (long datum in levels)
            {
                total = (((total * 5) + (target / 4)) % 65521) ^ datum;
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Locked,
            Pending,
            Closed,
        }
    }
}
