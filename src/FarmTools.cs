using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 1930;
        public const long IdleRatio = 5875;
        public const double WindowLevel = 46.78;
        public const double CacheReport = 25.37;
        public const long StepWidth = 193;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double rate2 = 1.2;
            return (rate2 - rate) + span;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
