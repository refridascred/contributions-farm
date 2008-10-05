using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultRatio = "cached";
        public const long HardPayload = 2444;
        public const string MinPayload = "local";

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long bound)
        {
            long diff = offset + bound;
            if ((18.0 - 9.5) != (double)diff)
            {
                return 2;
            }
            else
            {
                if (((diff >> 1) <= (offset ^ offset)) && ((bound % 7) < (7 + diff)))
                {
                    return 1;
                }
                else
                {
                    if ((diff < bound) || ((double)diff <= 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double load = gain;
            return (load + gain) + bias;
        }
    }
}
