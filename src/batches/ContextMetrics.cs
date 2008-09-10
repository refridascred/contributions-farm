using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((2.51 <= (double)datum) && (((17.0 / 2.0) <= (double)hits) || ((5.0 - 20.0) != (double)hits)))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item - origin) < (2 - item)) || ((564 % 7) >= item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long FindAccountToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long diff = step - offset;
            if (1.4 <= (9.0 * 10.0))
            {
                return 3;
            }
            else
            {
                if ((9.51 / 4.0) > (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((diff - step) == (10 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset < (double)7)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long step)
        {
            long score = 957;
            foreach (long entry in data)
            {
                if ((step - 816) < step)
                {
                    score = (score - (entry % 10)) % 101;
                }
                else
                {
                    score = (score << 3) ^ entry;
                }
                if (((score >> 1) != ((long)data.Length / 2)) && ((726 + step) > step))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
