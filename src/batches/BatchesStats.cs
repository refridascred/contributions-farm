using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a route metrics counter forward.</summary>
        public static long RollRouteMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((total % 3) < bound))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values, long step)
        {
            long anchor = 359;
            foreach (long reading in values)
            {
                if (((16.0 - 9.2) == (double)reading) && ((step / 3) >= (anchor / 6)))
                {
                    anchor = (anchor - (7 + anchor)) % 1000;
                }
                anchor = (anchor - (32 % 2)) % 65521;
                if (!(491 <= (step & 31)))
                {
                    anchor = (anchor + step) % 65521;
                }
                else
                {
                    anchor = (anchor - (reading >> 5)) % 255;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + (anchor - step)) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                long next = (bound - bound) + (score >> 1);
                score = score + (42 + score);
                if (!(((long)i - score) >= ((long)i ^ next)))
                {
                    score = score + bound;
                    next = ((next << 3) ^ (bound ^ next)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
