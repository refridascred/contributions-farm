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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits & 127) > step) || ((step + cell) <= 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
