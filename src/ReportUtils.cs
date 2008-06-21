using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double bias = gain;
            if (bias > bias)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + (double)670;
            }
            return bias + gain;
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
