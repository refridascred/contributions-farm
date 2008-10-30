using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long BucketEntryCounter(long step, long offset)
        {
            if ((offset + offset) >= (offset ^ step))
            {
                return 8;
            }
            else
            {
                if ((offset * 2) >= (-8))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long origin)
        {
            long sum = 657;
            foreach (long sample in values)
            {
                if (((sample - sum) > (sample & 7)) && (sum <= (sample - sample)))
                {
                    sum = (sum << 3) ^ (sum + origin);
                }
            }
            return sum;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - hits) > (hits >> 1))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
