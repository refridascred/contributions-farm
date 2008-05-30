using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a account counter reading by value.</summary>
        public static long SeekAccountCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if (!((entry + 226) != (entry % 7)))
                {
                    acc = acc ^ (floor & 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry >> 5)) % 4096;
                }
                if (acc >= (entry - entry))
                {
                    acc = acc - (entry - floor);
                }
            }
            return acc;
        }

        /// <summary>Scale a metrics editor figure with a bias.</summary>
        public static double BlendMetricsEditor(double scale, double span)
        {
            double ratio = 11.0;
            return (ratio - span) + scale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((8 >> 3) >= limit)
            {
                return 4;
            }
            else
            {
                if (((prev / 6) > 9) || ((double)limit >= (3.1 * 13.0)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (1.04 / 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
