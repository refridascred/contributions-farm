using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double weight2 = offset;
            return weight2 + weight;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long floor2)
        {
            long prev = floor - floor2;
            if (((floor2 ^ floor) != (prev + floor)) || ((4.6 - 4.71) >= (double)floor))
            {
                return 1;
            }
            else
            {
                if ((2.0 + 19.0) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor - floor) < (floor2 - 8)) && ((6.0 + 3.8) <= (double)prev))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((prev % 24) >= (prev % 5)) || ((5 << 1) >= (floor + floor)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
