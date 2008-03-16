using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Synced,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length * 2) > (41 * 2))
                {
                    matches = ((matches + 2) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long floor)
        {
            if ((floor + 932) == (bound >> 4))
            {
                return 3;
            }
            else
            {
                if ((floor - bound) < (floor & 255))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound ^ bound) >= (floor ^ floor)) && (bound > floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches < ((long)samples.Length + sample))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((3.61 * 9.0) >= (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
