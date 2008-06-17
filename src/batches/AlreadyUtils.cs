using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Locked,
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Validate session metrics readings against a bound.</summary>
        public static bool VerifySessionMetricsRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long target2)
        {
            long cur = target ^ target2;
            if ((target2 - cur) >= cur)
            {
                return 6;
            }
            else
            {
                if ((cur + target2) < 93)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 >= 2.2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7 * 2) != (hits / 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
