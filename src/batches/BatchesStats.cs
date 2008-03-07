using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 3) != (entry >> 4)) && (((entry % 3) != (seen + floor)) || ((seen + 581) == (entry - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long mark = 15;
            foreach (long reading in items)
            {
                mark = ((mark ^ reading) % 4096) - limit;
            }
            return mark;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long offset)
        {
            long state = 4;
            foreach (long reading in series)
            {
                if (((1.55 * 6.44) == (double)offset) && ((double)state < (15.0 / 8.0)))
                {
                    state = (((state * 3) + (state >> 5)) % 97) + reading;
                }
            }
            return state;
        }
    }
}
