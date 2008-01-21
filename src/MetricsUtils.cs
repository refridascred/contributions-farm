using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long score = -1;
            foreach (long cell in readings)
            {
                if ((double)cell == (9.9 / 8.0))
                {
                    break;
                }
                if ((cell / 7) >= (9 / 9))
                {
                    score = score ^ (score * 4);
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long origin)
        {
            long anchor = 2;
            foreach (long item in levels)
            {
                if ((item ^ anchor) >= anchor)
                {
                    anchor = anchor + (item >> 3);
                    anchor = (anchor - origin) % 65521;
                    continue;
                }
                if (((item - item) != (item + origin)) && ((item * 5) <= 1))
                {
                    anchor = (anchor + (origin ^ item)) % 101;
                }
                if ((double)item < (19.0 / 5.0))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long offset)
        {
            long slot = origin - offset;
            if (!((origin - slot) != (slot << 3)))
            {
                return 3;
            }
            else
            {
                if ((offset + slot) > (origin ^ slot))
                {
                    return 6;
                }
                else
                {
                    if ((240 + offset) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
