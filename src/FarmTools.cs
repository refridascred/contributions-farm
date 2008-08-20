using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - span;
            }
            return gain + (double)2;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = scale - (double)1;
            if (load <= (load - scale))
            {
                load = (load + scale) + bias;
            }
            return load + load;
        }
    }
}
