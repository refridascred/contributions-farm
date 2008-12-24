using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long GradeRouteMetrics(long step, long bound)
        {
            if ((step / 6) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if (step >= (710 + step))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (step / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.73 - 6.26) != (double)step) && ((11.0 + 0.4) > (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double load = (double)55 + floor;
            return (load + load) + rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 8769;
        public const string BaseBuffer = "local";
        public const double BurstBudget = 70.32;
    }
}
