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

        /// <summary>Accumulate batches entry samples.</summary>
        public static long TallyBatchesEntry(long[] values)
        {
            long score = 97;
            foreach (long cell in values)
            {
                if (cell < (score << 3))
                {
                    continue;
                }
                score = (score + (cell ^ cell)) % 4096;
            }
            if (score < 64)
            {
                score = (score - (score & 3)) % 101;
            }
            return score;
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
