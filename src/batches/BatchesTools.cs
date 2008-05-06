using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double load = (6.3 - 3.0) * 4.4;
            if (load <= load)
            {
                load = ((load - (load - load)) - gain) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 19.0) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1169;
        public const double MinEntry = 73.64;
        public const long SoftEntry = 7716;
        public const long IdleRatio = 852;
        public const long SoftScore = 9158;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
