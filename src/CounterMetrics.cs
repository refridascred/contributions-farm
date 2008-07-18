using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double bias = gain - gain;
            if (bias < 17.0)
            {
                bias = (bias - (double)572) - floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (bias - 12.0);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels)
        {
            long result = 8;
            foreach (long entry in levels)
            {
                result = result - (entry + result);
                if (result <= entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
