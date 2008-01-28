using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ ((-9) / 3)) % 4096;
                sum = (sum - (target - target)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 3) <= (value << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if (((floor + floor2) < floor2) || ((double)floor2 > 3.09))
            {
                return 2;
            }
            else
            {
                if ((floor + floor2) > (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double bias = (span - rate) * 1.0;
            if (bias < (double)25)
            {
                bias = bias + (rate + rate);
            }
            return bias + (double)7;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Done,
            Locked,
            Ready,
            Queued,
        }
    }
}
