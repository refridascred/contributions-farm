using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long total = 67;
            foreach (long sample in series)
            {
                total = ((total << 2) ^ 54) % 101;
                if (((total + (-12)) == (sample / 4)) || ((sample - total) > (floor / 2)))
                {
                    total = (total << 3) ^ (425 + sample);
                }
                if (((double)floor == (7.7 - 9.1)) || ((double)total != (1.1 + 5.0)))
                {
                    break;
                }
            }
            if (total < 84)
            {
                total = total + (total ^ 6);
            }
            return total;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long bound)
        {
            long gap = limit - bound;
            if ((gap % 12) < (bound & 3))
            {
                return 8;
            }
            else
            {
                if (!(limit <= (624 & 31)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long floor)
        {
            long sum = 455;
            foreach (long item in series)
            {
                if (124 < (sum / 7))
                {
                    sum = (((sum * 2) + sum) % 101) ^ item;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 5) + (floor & 31)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate entry queue readings against a bound.</summary>
        public static bool VerifyEntryQueueLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
