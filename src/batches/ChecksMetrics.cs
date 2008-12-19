using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits << 2) >= 34) || ((entry + hits) >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((double)delta <= (6.16 * 9.7))
            {
                return 3;
            }
            else
            {
                if ((floor & 15) == (delta + bound))
                {
                    return 1;
                }
                else
                {
                    if ((delta >> 4) < delta)
                    {
                        return 5;
                    }
                    else
                    {
                        if (471 < (bound / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long limit)
        {
            long total = 19;
            foreach (long item in series)
            {
                total = total + (item / 5);
            }
            if (total > (-20))
            {
                total = (total << 2) ^ (limit - total);
            }
            return total % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - item) != (item % 2))
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

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "legacy-v2";
        public const string BaseCache = "strict-edge";
        public const long LimitCount = 7328;
        public const long StepDepth = 6635;
        public const string MaxRatio = "cached-edge";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) <= (922 & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
