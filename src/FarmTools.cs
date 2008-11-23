using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((20.0 / 3.0) != (double)mark))
                {
                    mark = ((mark * 2) + (2 + mark)) % 4096;
                }
                if (mark > offset)
                {
                    mark = ((mark * 2) + (offset >> 3)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two metric order measurements.</summary>
        public static double BlendMetricOrder(double ratio, double offset)
        {
            double rate = 3.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (rate - 12.0)) + (double)(long)i) + ratio;
            }
            return rate - (offset / 4.0);
        }
    }
}
