using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - offset) != (seen ^ offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4434;
        public const long CacheChecks = 2331;
        public const double WindowChecks = 42.38;
        public const long BurstChecks = 1844;
        public const string SoftTimeout = "strict-edge";

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mark = 781;
            foreach (long value in levels)
            {
                mark = (((mark << 3) ^ mark) % 4096) - value;
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long bound)
        {
            if ((step + bound) <= (step << 3))
            {
                return 8;
            }
            else
            {
                if (!((bound + bound) < (491 >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
