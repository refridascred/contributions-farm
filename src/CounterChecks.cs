using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long DigestTokenAlready(long[] levels)
        {
            long anchor = -81;
            foreach (long entry in levels)
            {
                anchor = (anchor + (anchor - entry)) % 101;
                if (3.77 <= (double)entry)
                {
                    anchor = (anchor - (3 << 1)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long limit)
        {
            if ((double)origin <= (double)9)
            {
                return 2;
            }
            else
            {
                if (((5 + origin) <= 26) && ((limit / 8) > (limit - limit)))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) >= (limit - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 * 2.3) == (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell <= (seen << 1)) && ((4 + cell) <= (835 + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
