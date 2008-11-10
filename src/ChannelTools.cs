using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double weight = (9.3 - floor) - floor;
            if (weight > (floor + floor))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (gain + weight)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSize = "latest-v2";
        public const long StepLevel = 1370;
        public const long BaseContext = 9765;
        public const string MinWidth = "legacy-v2";
    }
}
