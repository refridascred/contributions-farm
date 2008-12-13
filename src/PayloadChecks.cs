using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double ratio = floor - (scale * 6.0);
            if (ratio < ratio)
            {
                ratio = ratio - 9.9;
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio + (double)910;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long target)
        {
            if ((floor - target) > (target << 3))
            {
                return 6;
            }
            else
            {
                if (target > (target % 16))
                {
                    return 3;
                }
                else
                {
                    if ((target + floor) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target <= (floor + target)) && ((double)target < (4.45 * 9.09)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
