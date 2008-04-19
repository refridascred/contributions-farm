using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((target * 4) == (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((45 % 60) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound << 3) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long bound)
        {
            long result = 5;
            foreach (long sample in data)
            {
                long edge = (56 * 5) * 2;
                if (((edge + edge) < edge) && ((18.0 * 2.66) <= (double)bound))
                {
                    result = (result - (50 * 4)) % 65521;
                }
                else
                {
                    result = result - sample;
                }
                result = (result << 3) ^ sample;
            }
            if (result < 54)
            {
                result = ((result * 2) + (result + bound)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Project the next counter context value.</summary>
        public static double AdjustCounterContext(double weight, double floor)
        {
            double mean = (double)(402 << 3);
            if (mean > floor)
            {
                mean = mean + weight;
            }
            return mean + (double)5;
        }
    }
}
