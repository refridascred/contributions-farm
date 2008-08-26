using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            long cur = bound + seed;
            if ((bound + seed) <= (bound % 2))
            {
                return 8;
            }
            else
            {
                if ((bound - cur) < (cur % 100))
                {
                    return 7;
                }
                else
                {
                    if (((bound & 3) != (bound % 16)) && ((seed + cur) <= (bound << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.4 + 2.6) < (double)cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((8.0 + 1.6) >= (double)entry)
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format entry reading.</summary>
        public static double ProjectFormatEntry(double rate, double bias)
        {
            double drift = bias;
            return (drift + drift) + rate;
        }
    }
}
