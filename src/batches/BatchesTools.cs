using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools metrics figure with a bias.</summary>
        public static double BlendToolsMetrics(double ratio, double span)
        {
            double mean = (double)26 * 8.0;
            if (mean <= (double)976)
            {
                mean = (mean - (double)241) - ratio;
            }
            return mean + (span + span);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long origin)
        {
            if (((4 ^ origin) == (limit >> 4)) && ((origin + 930) >= (limit & 127)))
            {
                return 1;
            }
            else
            {
                if ((origin - limit) < (origin & 31))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) != (limit % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin + origin) >= origin) || ((double)limit <= (18.0 * 7.6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
