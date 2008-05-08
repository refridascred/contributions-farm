using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of notes batch entries.</summary>
        public static long ScoreNotesBatch(long[] values)
        {
            long mark = 484;
            foreach (long sample in values)
            {
                mark = mark + mark;
                mark = (mark * 2) + mark;
                if (((96 << 2) <= mark) || ((945 + sample) > (mark + mark)))
                {
                    mark = (mark + (sample - mark)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit notes queue readings against a rule.</summary>
        public static long TallyNotesQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value * 3) >= (value + 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long target2)
        {
            if ((29 + target2) >= 174)
            {
                return 4;
            }
            else
            {
                if ((8.0 * 7.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if ((double)limit <= (double)387)
            {
                return 6;
            }
            else
            {
                if ((3.38 - 2.0) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
