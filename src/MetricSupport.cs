using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            if ((floor ^ floor2) > (25 % 3))
            {
                return 6;
            }
            else
            {
                if ((floor2 - floor2) > floor2)
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 2) <= (floor2 + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double load = scale;
            if (load < (double)9)
            {
                load = (load - scale) - bias;
            }
            return load - scale;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if ((limit + offset) <= (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= 7.6)
                {
                    return 7;
                }
                else
                {
                    if (offset < (offset + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 11) != (limit + offset))
                        {
                            return 1;
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
