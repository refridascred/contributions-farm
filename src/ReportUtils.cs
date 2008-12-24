using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowTimeout = "local-edge";
        public const string WindowPayload = "staging-1";
        public const double BasePayload = 21.04;

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

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (bound << 1)) % 1000) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 8769;
        public const string BaseBuffer = "local";
        public const double BurstBudget = 70.32;
    }
}
