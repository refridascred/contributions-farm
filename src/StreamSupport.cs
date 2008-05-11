using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double load = weight + floor;
            if (load <= floor)
            {
                load = load + floor;
            }
            return load - (1.86 - weight);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 66.27;
        public const long StepCounter = 6216;
        public const double HardCounter = 66.54;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
