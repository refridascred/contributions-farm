using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen > (5.7 * 1.4))
                {
                    seen = ((seen + 1) - reading) - floor;
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm stream input into a small class.</summary>
        public static long RankGithubfarmStream(long floor, long origin)
        {
            if (622 >= floor)
            {
                return 0;
            }
            else
            {
                if ((37 * 3) > (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= (origin % 97)) && ((double)(-541) <= (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin << 2) >= floor) && ((7.0 * 16.0) < (double)floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleSpan = 8474;
        public const long RetryScore = 4753;
        public const long IdlePayload = 1060;
        public const long BurstPayload = 3331;
        public const long HardCount = 7729;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
