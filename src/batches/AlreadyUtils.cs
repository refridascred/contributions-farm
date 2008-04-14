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

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            if ((-481) >= floor2)
            {
                return 4;
            }
            else
            {
                if ((floor * 4) != ((-729) >> 3))
                {
                    return 6;
                }
                else
                {
                    if (3.1 <= (double)floor2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor2 >> 3) >= (floor2 + floor2)) || ((double)floor > 7.8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
