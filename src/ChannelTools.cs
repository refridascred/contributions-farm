using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of githubfarm record entries.</summary>
        public static long TallyGithubfarmRecord(long[] values, long limit)
        {
            long result = 962;
            foreach (long reading in values)
            {
                if (7.2 <= (double)limit)
                {
                    result = (result << 2) ^ (limit + result);
                }
                else
                {
                    result = ((result << 3) ^ (reading << 1)) % 101;
                }
                if (!((double)result > (5.5 - 3.32)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long target)
        {
            long total = 472;
            foreach (long value in levels)
            {
                if (!((0.1 - 9.5) > (double)target))
                {
                    total = total - target;
                }
                total = total - (511 + value);
                total = total + (total % 12);
            }
            return total;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
