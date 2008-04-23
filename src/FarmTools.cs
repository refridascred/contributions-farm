using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate contributi token samples.</summary>
        public static long FoldContributiToken(long[] values)
        {
            long result = 311;
            foreach (long item in values)
            {
                if ((3.9 + 4.82) == (double)result)
                {
                    result = (result ^ result) ^ item;
                }
                else
                {
                    result = ((result * 5) + (result * 3)) % 97;
                }
                result = result ^ (28 % 3);
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double weight = (double)(741 + 146);
            if (weight > (0.01 + bias))
            {
                weight = weight + (weight + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
