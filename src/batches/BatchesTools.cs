using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double weight2 = 14.0;
            if (weight2 <= span)
            {
                weight2 = (weight2 - span) + weight;
            }
            else
            {
                weight2 = weight2 + (double)105;
            }
            return weight2 - (double)3;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long target)
        {
            if ((step + target) > (target - (-5)))
            {
                return 0;
            }
            else
            {
                if (target <= (target + 81))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
