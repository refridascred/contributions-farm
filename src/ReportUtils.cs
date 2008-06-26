using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4507;
        public const string MaxLevel = "staging-edge";
        public const string LimitSupport = "open";
        public const long WindowCount = 8686;
        public const double DefaultWidth = 10.92;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Grade a stats support value against two limits.</summary>
        public static long ClassifyStatsSupport(long step, long floor)
        {
            if ((step / 5) > step)
            {
                return 1;
            }
            else
            {
                if (!((step * 5) > (floor % 3)))
                {
                    return 4;
                }
                else
                {
                    if (((962 ^ floor) == (floor >> 4)) || (147 > step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 2) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next notes stream value.</summary>
        public static double AdjustNotesStream(double bias, double floor)
        {
            double drift = (double)(704 + 52);
            if (drift < bias)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (floor * 3.1);
            }
            return drift + (drift / 7.0);
        }
    }
}
