using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitCount = 8491;
        public const long StepFactor = 166;
        public const string HardScore = "legacy-edge";
        public const long StepProfile = 2559;

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double gain = (weight + offset) + 9.0;
            if (gain >= (double)62)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (double)30;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
