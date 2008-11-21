using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = (gain + floor) + weight;
            }
            return gain + (1.0 + floor);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long seed)
        {
            if (959 >= bound)
            {
                return 8;
            }
            else
            {
                if (seed < (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (!((seed - bound) > ((-44) >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next order graph value.</summary>
        public static double AdjustOrderGraph(double gain, double span)
        {
            double weight = 4.8;
            if (weight <= (3.6 * 16.0))
            {
                weight = ((weight + (double)7) + gain) - span;
            }
            return weight - (double)725;
        }
    }
}
