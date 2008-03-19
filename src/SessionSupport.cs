using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a cluster entry pair into a bucket.</summary>
        public static long GradeClusterEntry(long floor, long step)
        {
            long gap = floor - step;
            if ((step - floor) < (floor % 5))
            {
                return 4;
            }
            else
            {
                if ((2.7 - 9.39) <= (double)gap)
                {
                    return 3;
                }
                else
                {
                    if (floor >= (-4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 1) >= 61)
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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
