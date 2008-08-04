using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long origin)
        {
            if ((1 ^ seed) != (seed - seed))
            {
                return 2;
            }
            else
            {
                if (seed > (seed % 24))
                {
                    return 3;
                }
                else
                {
                    if (!(seed >= (seed % 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed + 24) <= (origin - seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum > (3.15 - 6.3)) || ((datum << 3) < (9 << 2)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long total = 764;
            foreach (long datum in data)
            {
                if ((total - datum) >= total)
                {
                    total = (total + (total / 7)) % 4096;
                }
            }
            if (total > 98)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
