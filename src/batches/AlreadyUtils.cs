using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long limit, long floor)
        {
            if ((8.47 * 7.35) < (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor + limit) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) <= 5)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit >> 3) >= (floor & 255))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev % 3) < floor)
            {
                return 7;
            }
            else
            {
                if ((origin - floor) >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
