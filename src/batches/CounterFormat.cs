using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 38;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ 62) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (bound % 97)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            if (!(limit > (limit * 3)))
            {
                return 8;
            }
            else
            {
                if ((5 << 3) < (0 - limit))
                {
                    return 1;
                }
                else
                {
                    if ((9 + limit) <= (seed >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
