using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double bias)
        {
            double drift = (double)802 + (double)8;
            if (drift <= weight)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - (bias * 2.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4995;
        public const double BaseWidth = 94.59;
        public const long IdleDepth = 6223;

        /// <summary>Roll a record commits counter forward.</summary>
        public static long IterateRecordCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((offset - (long)i) != (25 / 3)))
                {
                    result = result + offset;
                    result = (result - result) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
