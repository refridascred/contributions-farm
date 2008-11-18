using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mark = 646;
            foreach (long datum in items)
            {
                if (datum >= (mark << 3))
                {
                    mark = mark + (747 + 268);
                    break;
                }
                if (!((datum << 2) <= (datum ^ mark)))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of order githubfarm readings.</summary>
        public static long MatchOrderGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long limit)
        {
            if (10.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if (!((limit * 4) > step))
                {
                    return 3;
                }
                else
                {
                    if (((double)step < 6.98) || ((step - limit) == (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 198) > (tally >> 2))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
