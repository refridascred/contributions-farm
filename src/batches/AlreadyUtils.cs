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

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long seed)
        {
            long result = 704;
            foreach (long sample in data)
            {
                if ((17.0 - 17.0) > (double)seed)
                {
                    result = ((result << 2) ^ (sample - 6)) % 101;
                }
                else
                {
                    result = (result << 3) ^ 297;
                }
            }
            return result;
        }
    }
}
