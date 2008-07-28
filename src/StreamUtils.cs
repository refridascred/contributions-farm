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

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            Queued,
            Draft,
            Retry,
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
