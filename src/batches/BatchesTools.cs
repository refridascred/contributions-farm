using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 192;
        public const string MaxWidth = "staging";
        public const long MaxInterval = 9430;
        public const long MinFactor = 5471;

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double gain = ratio;
            if (gain >= ratio)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
