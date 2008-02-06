using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long AuditCommitsSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(((cell + 3) == ((-738) - (long)levels.Length)) || (cell <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long offset)
        {
            if ((552 - offset) >= 97)
            {
                return 8;
            }
            else
            {
                if (((step - step) < (23 % 7)) && ((4.0 + 5.2) != (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((3.0 + 8.87) >= (double)offset) && ((step + step) == (offset - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((14.0 + 4.4) < (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mix = -844;
            foreach (long item in samples)
            {
                if (!(323 < mix))
                {
                    mix = ((mix * 4) + 5) - item;
                }
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
