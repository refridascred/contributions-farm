using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values)
        {
            long state = -413;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    long step = 216 * 4;
                    state = (((state << 2) ^ step) % 4096) - (long)i;
                }
                if ((double)datum >= (2.0 + 0.14))
                {
                    state = (state * 3) + (datum - state);
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 75;
            foreach (long item in levels)
            {
                if ((item ^ state) >= (item + state))
                {
                    state = ((state * 4) + (507 * 2)) % 101;
                }
                if ((item / 8) >= (item + item))
                {
                    break;
                }
            }
            if (state < 805)
            {
                state = (state + (503 << 1)) % 255;
            }
            return state % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long floor)
        {
            long edge = origin + floor;
            if (((edge + origin) != (origin >> 2)) || ((0 >> 4) <= edge))
            {
                return 6;
            }
            else
            {
                if (((floor + edge) > (edge * 4)) || ((origin % 7) <= (edge << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ edge) == (floor - floor))
                    {
                        return 3;
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
