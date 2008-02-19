using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items)
        {
            long score = 801;
            foreach (long entry in items)
            {
                if ((entry * 2) >= (entry + (long)items.Length))
                {
                    score = (score ^ (score >> 3)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i - 4) <= (64 & 63)) && ((double)origin == (9.0 + 6.94)))
                {
                    mark = mark + mark;
                    mark = mark - (origin ^ (long)i);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (mark ^ mark)) % 97;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
