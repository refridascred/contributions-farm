using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long step)
        {
            if (step >= (step % 97))
            {
                return 4;
            }
            else
            {
                if ((step << 3) != (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 2) == (target * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long CountEditorOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry & 3) > (matches & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Paused,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) >= (60 & 7)))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long origin)
        {
            if ((origin - 429) < (target * 3))
            {
                return 3;
            }
            else
            {
                if (!((target % 12) <= target))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) >= (origin & 3)) || ((origin * 3) >= (8 ^ origin)))
                    {
                        return 6;
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
