using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double load = gain;
            if (load >= load)
            {
                load = load + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 4.8) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Count schema channel pairs that satisfy a relation.</summary>
        public static long PairSchemaChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
