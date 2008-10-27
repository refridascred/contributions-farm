using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry queue entry stays within the limit.</summary>
        public static bool CheckEntryQueueLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank tools stats input into a small class.</summary>
        public static long GradeToolsStats(long origin, long offset)
        {
            if ((origin * 4) >= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((99 / 9) > origin) && ((origin + offset) <= origin))
                {
                    return 1;
                }
                else
                {
                    if (offset >= (147 ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 3) == (offset & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double bias = 9.7;
            if (bias > (double)69)
            {
                bias = (bias + (5.25 * 9.22)) - weight;
            }
            return bias - (span / 9.0);
        }
    }
}
