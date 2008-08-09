using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((446 - floor) > ((long)items.Length - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "local-v2";
        public const long RetryGithubfarm = 5948;
        public const double BatchScore = 17.27;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] values, long bound)
        {
            long anchor = 81;
            foreach (long entry in values)
            {
                anchor = (anchor - (entry / 7)) + bound;
                if ((anchor + anchor) <= entry)
                {
                    break;
                }
            }
            if (anchor > 444)
            {
                anchor = (anchor - (68 >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long step)
        {
            long prev = target - step;
            if ((double)target != (7.8 + 3.21))
            {
                return 7;
            }
            else
            {
                if ((double)109 >= (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (target < (prev - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.37 / 3.0) >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) == (2 ^ 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
