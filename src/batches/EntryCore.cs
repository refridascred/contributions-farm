using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first support filter entry that matches the target.</summary>
        public static long LocateSupportFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Draft,
            New,
            Closed,
            Ready,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((floor - bound) <= bound)
            {
                return 3;
            }
            else
            {
                if (15.0 > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound % 16) >= (-8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((lane & 3) > 11) || ((6.9 + 2.3) < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 88.79;
        public const long DefaultSupport = 1556;
        public const long BaseSupport = 7887;
    }
}
