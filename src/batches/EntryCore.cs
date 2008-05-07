using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (target > (sample % 100))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if (2.0 >= (4.8 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((9 - bound) == (target >> 4))
                {
                    return 1;
                }
                else
                {
                    if (target <= (27 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
