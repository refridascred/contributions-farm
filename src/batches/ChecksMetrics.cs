using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long mark = 63;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >> 3) != (step - mark))
                {
                    mark = (mark - mark) % 101;
                }
                if ((96 % 16) > step)
                {
                    mark = mark - (reading / 6);
                }
                if (((9.0 - 5.6) == (double)mark) || ((reading * 3) <= (18 + 293)))
                {
                    mark = (mark - (2 * 5)) % 4096;
                }
                else
                {
                    mark = (mark - (422 - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Validate batches buffer readings against a bound.</summary>
        public static bool CheckBatchesBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series, long bound)
        {
            long result = 22;
            foreach (long item in series)
            {
                if (result <= (bound * 3))
                {
                    result = result ^ (result << 3);
                }
                if (((76 - bound) <= (item ^ result)) || ((item + item) > (item << 2)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry > (entry << 1)) && ((count + 3) < (entry / 8)))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long target, long origin)
        {
            long next = target - origin;
            if ((origin < (86 * 5)) && ((next + target) == (target / 2)))
            {
                return 8;
            }
            else
            {
                if (((8.74 + 9.4) <= (double)origin) || ((79 + origin) <= (target + origin)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Active,
            Synced,
            Dropped,
        }
    }
}
