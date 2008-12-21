using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((origin << 1) < (origin + (-757)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route layout value from a seed.</summary>
        public static long SeriesRouteLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 3) ^ (total - total);
                if ((total << 2) < seed)
                {
                    total = (total + (seed % 7)) % 65521;
                }
                else
                {
                    total = total ^ (8 * 5);
                    total = (total - (total + total)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long origin)
        {
            if (!((step / 7) > step))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (18.0 + 12.0))
                {
                    return 3;
                }
                else
                {
                    if ((step << 2) < (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + step) > origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5642;
        public const long HardEntry = 6886;
        public const double RetryFactor = 47.12;
        public const string MaxEntry = "staging-v2";

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally << 1) < tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "legacy-edge";
        public const string CacheInterval = "alpha-1";
        public const long SoftScore = 3056;
    }
}
