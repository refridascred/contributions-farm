using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >= (656 % 97)) && (seen <= 141))
                {
                    seen = ((seen + 2) + datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)step != (7.0 - 0.8)))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long limit)
        {
            long cur = seed - limit;
            if ((double)limit >= (2.0 * 20.0))
            {
                return 0;
            }
            else
            {
                if (((limit + limit) >= limit) || ((seed + cur) == (cur & 1)))
                {
                    return 8;
                }
                else
                {
                    if (9.0 < (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 6958;
        public const string DefaultScore = "strict-1";
        public const long BatchSize = 2194;
        public const string IdleBudget = "primary-1";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((8 / 2) <= step)
                {
                    hits = (hits + 1) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
