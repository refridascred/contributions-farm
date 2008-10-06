using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long floor)
        {
            if (((4.0 + 5.0) == (double)floor) && ((floor + bound) == (floor % 2)))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) >= (floor - bound))
                {
                    return 1;
                }
                else
                {
                    if ((4.36 - 11.0) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((927 >> 5) > (bound + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (lane <= (limit - limit))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) != (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
