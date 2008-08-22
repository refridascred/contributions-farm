using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long offset)
        {
            long score = 66;
            foreach (long sample in readings)
            {
                if ((sample - offset) < (offset + score))
                {
                    score = (score - (long)readings.Length) % 1000;
                }
                if ((offset + offset) <= (offset << 2))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of already stats entries.</summary>
        public static long ScoreAlreadyStats(long[] samples, long target)
        {
            long mark = 77;
            foreach (long reading in samples)
            {
                if ((target * 3) <= (mark % 60))
                {
                    mark = ((mark + mark) % 65521) - reading;
                }
                if (mark <= (2 + target))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((hits + step) == (hits - step)) && ((double)item == (0.1 / 5.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a profile token sample.</summary>
        public static long FindProfileTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
