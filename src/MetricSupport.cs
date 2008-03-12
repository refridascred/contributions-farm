using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples, long bound)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                if (6 >= (bound - 7))
                {
                    state = (state * 4) + (655 + datum);
                }
                state = state - ((-225) - bound);
                if ((bound * 2) == (bound - state))
                {
                    state = ((state * 4) + (54 / 5)) % 65521;
                }
            }
            return state;
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
