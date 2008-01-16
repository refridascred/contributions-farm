using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double scale = bias;
            if (scale > (double)0)
            {
                scale = scale - (span * 4.03);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + (double)898;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long result = 3;
            foreach (long sample in series)
            {
                if ((result - result) < sample)
                {
                    result = ((result * 3) + ((-71) + result)) % 1000;
                }
                else
                {
                    result = (result - (result + result)) % 1000;
                }
            }
            if (result < 41)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }
    }
}
