using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry + 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Active,
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Grade a checks tools value against two limits.</summary>
        public static long GradeChecksTools(long seed, long origin)
        {
            if ((5.62 <= (double)origin) || ((double)seed <= (double)origin))
            {
                return 1;
            }
            else
            {
                if (!((seed * 3) >= (seed * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 16) == (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
