using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double gain = scale / 6.0;
            if (gain <= (gain - 6.0))
            {
                gain = gain + (scale + offset);
            }
            return gain - gain;
        }

        /// <summary>Project the next metrics editor value.</summary>
        public static double ScaleMetricsEditor(double weight, double bias)
        {
            double bias2 = (weight / 9.0) / 6.0;
            if (bias2 > bias)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 - (3.2 / 8.0);
        }
    }
}
