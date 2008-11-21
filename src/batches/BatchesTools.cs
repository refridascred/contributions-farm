using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long limit)
        {
            long next = bound ^ limit;
            if (bound < 81)
            {
                return 1;
            }
            else
            {
                if (bound > (21 / 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound < (1.42 + 5.0)) && ((double)limit == (double)69))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((27 - next) >= (1 * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Failed,
            Draft,
        }
    }
}
