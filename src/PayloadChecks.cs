using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long ClassifyMetricCommits(long target, long floor)
        {
            if ((floor - target) == (floor + floor))
            {
                return 2;
            }
            else
            {
                if (((20.0 - 11.0) == (double)target) && ((target + target) >= (floor ^ 4)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) <= (target - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((79 + target) != (floor - target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double rate = (double)(-9) + (gain - 20.0);
            if (rate < gain)
            {
                rate = (rate - (rate - rate)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (0.24 * 2.2)) + (double)(long)i;
            }
            return rate - (double)53;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev >= (prev << 1)) && (floor <= (prev >> 3)))
            {
                return 7;
            }
            else
            {
                if ((2.9 + 3.38) <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((origin < (floor ^ prev)) && (2.0 > (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ origin) >= (floor + prev))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
