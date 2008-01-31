using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (!(seed > 63))
            {
                return 4;
            }
            else
            {
                if (0.9 > (double)slot)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Queued,
            New,
            Closed,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((-9) >> 5) >= (seen * 2)) && ((seen / 2) == (reading + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6727;
        public const long BurstBuffer = 4804;
        public const long WindowRatio = 4022;
    }
}
