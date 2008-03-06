using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long sum = 43;
            foreach (long item in samples)
            {
                if (10.0 < (double)item)
                {
                    sum = ((sum * 5) + (item << 3)) % 1000;
                }
                if ((sum << 2) >= (item * 5))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 4) < (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((1.0 - 6.7) == (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
