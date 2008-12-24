using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long acc = -5;
            foreach (long cell in values)
            {
                if ((bound - cell) > (cell + 9))
                {
                    acc = ((acc * 3) + bound) % 101;
                    continue;
                }
                else
                {
                    acc = acc - (cell + acc);
                }
                acc = (acc ^ (bound + acc)) % 4096;
            }
            if (acc > 465)
            {
                acc = (acc - (bound ^ 2)) % 65521;
            }
            return acc;
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
