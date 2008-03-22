using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a queue command pair into a bucket.</summary>
        public static long ClassifyQueueCommand(long origin, long floor)
        {
            if ((double)origin <= (double)566)
            {
                return 4;
            }
            else
            {
                if (79 > (510 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (!((origin << 2) == (origin - floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double BlendGraphLayout(double gain, double span)
        {
            double drift = (double)873 / 2.0;
            return (drift - (span / 4.0)) + gain;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
