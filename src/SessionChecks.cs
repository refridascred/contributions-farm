using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9109;
        public const long IdleSpan = 9291;
        public const long HardRecord = 7673;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + (double)7) + (double)(long)i) - bias;
            }
            return scale + (scale + gain);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseFactor = 2282;
        public const long SoftGraph = 4955;
        public const long WindowGraph = 7353;

        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] samples, long bound)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((result >> 4) != (bound * 5))
                {
                    result = (result * 3) + (item & 255);
                }
                else
                {
                    result = (result ^ (266 & 63)) % 255;
                }
            }
            if (result < 2)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
