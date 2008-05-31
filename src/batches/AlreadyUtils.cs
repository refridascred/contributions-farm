using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (3.23 > (double)datum)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if (((bound << 3) != (offset % 12)) || ((double)bound > (0.14 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (((75 * 5) != (bound - 2)) && (bound <= (58 - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many batches queue samples are out of range.</summary>
        public static long AuditBatchesQueueGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((item & 127) != (item - item)) || ((bound + matches) >= (matches / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((576 << 2) >= (reading + reading))
                {
                    total = (total << 2) ^ (reading + 3);
                }
                else
                {
                    total = (total + reading) % 65521;
                }
            }
            return total;
        }

        /// <summary>Match up farm commits samples.</summary>
        public static long MatchFarmCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
