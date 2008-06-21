using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a account githubfarm pair into a bucket.</summary>
        public static long ClassifyAccountGithubfarm(long step, long limit)
        {
            if (!((8.55 * 1.0) <= (double)step))
            {
                return 4;
            }
            else
            {
                if (((step / 9) > (limit % 97)) && ((4.6 * 9.54) > (double)step))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool CheckCommitsTokenLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)step != (3.68 / 3.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long sum = 59;
            foreach (long cell in data)
            {
                if ((4.1 - 8.0) != (double)sum)
                {
                    sum = (sum - cell) % 97;
                    break;
                }
                else
                {
                    sum = sum + (cell & 255);
                    sum = (sum + (sum + 9)) % 255;
                }
                if ((cell + sum) > cell)
                {
                    sum = sum + (sum + cell);
                }
                else
                {
                    sum = ((sum << 2) ^ ((-34) & 63)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
