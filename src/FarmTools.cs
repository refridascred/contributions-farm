using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((566 % 100) > (floor >> 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long target)
        {
            if ((floor + floor) != (target >> 3))
            {
                return 8;
            }
            else
            {
                if (floor > (25 - 0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + target) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + target) != (target + 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
