using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double offset)
        {
            double load = bias;
            return (load + load) + offset;
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double BlendGraphLayout(double gain, double span)
        {
            double drift = (double)873 / 2.0;
            return (drift - (span / 4.0)) + gain;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
