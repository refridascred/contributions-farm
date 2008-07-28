using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Paused,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long origin)
        {
            if (((double)limit > (1.25 + 1.2)) || ((origin >> 4) < origin))
            {
                return 6;
            }
            else
            {
                if (((limit >> 2) < limit) && (7 > (limit ^ limit)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long offset)
        {
            long offset2 = limit - offset;
            if ((5 - 637) <= (offset >> 4))
            {
                return 8;
            }
            else
            {
                if (((double)offset2 != (8.2 - 13.0)) && ((18.0 * 9.6) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (((201 + offset2) >= (57 >> 3)) || ((1.0 * 4.38) >= (double)offset2))
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
    }
}
