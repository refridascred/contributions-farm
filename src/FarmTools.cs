using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowTimeout = 2367;
        public const long SoftEditor = 230;
        public const long DefaultTimeout = 952;
        public const long BaseSize = 1258;
        public const long RetryEditor = 9794;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double mean = 7.5 + (double)464;
            if (mean > mean)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (offset + 6.4);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 7.69) - (double)(long)i;
            }
            return mean - (offset + ratio);
        }
    }
}
