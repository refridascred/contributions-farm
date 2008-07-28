using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next checks already value.</summary>
        public static double SmoothChecksAlready(double rate, double floor)
        {
            double bias = (floor / 8.0) + rate;
            if (bias < 5.81)
            {
                bias = bias - rate;
            }
            return bias + (double)8;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long step)
        {
            if (7.36 >= (double)target)
            {
                return 6;
            }
            else
            {
                if (((step + 0) == (target + step)) || ((4.8 / 8.0) >= 1.58))
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step > (target * 3)) && ((target * 4) >= (target + target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank stream checks input into a small class.</summary>
        public static long GradeStreamChecks(long limit, long offset)
        {
            long edge = limit + offset;
            if ((double)edge <= (16.0 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((limit > (633 - offset)) && ((double)edge != (7.0 - 9.4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (0.94 * 0.25))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Idle,
            Failed,
            Stale,
            Locked,
        }
    }
}
