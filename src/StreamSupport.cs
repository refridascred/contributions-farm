using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= gain)
            {
                gain2 = gain2 - (double)122;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 + (gain + 0.7);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepCount = 8463;
        public const long CacheDepth = 7987;
        public const double StepWidth = 16.17;
        public const long WindowCount = 5674;
        public const double MaxBudget = 20.84;
    }
}
