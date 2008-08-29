using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - hits) <= 535)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank context route input into a small class.</summary>
        public static long ClassifyContextRoute(long bound, long seed)
        {
            if ((seed % 5) <= (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((seed >= (18 * 3)) || ((double)seed < (7.6 * 0.8)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
