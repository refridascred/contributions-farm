using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((1.35 / 9.0) > (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > (matches - reading))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if ((double)cell == (double)score)
                {
                    score = score ^ ((-62) + score);
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (3 / 4);
                }
                if (score >= (score - cell))
                {
                    score = score + (cell ^ cell);
                }
                else
                {
                    score = (score * 4) + (963 << 1);
                }
            }
            return score;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state - (long)i2) % 255;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
