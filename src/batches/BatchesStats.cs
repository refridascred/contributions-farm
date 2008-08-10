using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)(long)levels.Length < 8.4))
                {
                    tally = ((tally + 1) + reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings, long limit)
        {
            long anchor = 239;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 2) + limit) ^ entry;
                anchor = anchor + ((long)readings.Length % 64);
            }
            if (anchor < 161)
            {
                anchor = ((anchor << 2) ^ (limit * 4)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a layout support value against two limits.</summary>
        public static long GradeLayoutSupport(long bound, long step)
        {
            if ((step - bound) <= step)
            {
                return 3;
            }
            else
            {
                if (((double)step == (6.2 + 4.73)) && (bound < 581))
                {
                    return 6;
                }
                else
                {
                    if ((step - bound) < 0)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound < (1.43 - 8.9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
