using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double bias = offset * 6.8;
            if (bias <= (6.22 + offset))
            {
                bias = (bias + offset) + ratio;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - (double)70;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double load = gain;
            if (load > load)
            {
                load = (load - load) - span;
            }
            else
            {
                load = load - 5.0;
            }
            return load - load;
        }
    }
}
