using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + tally) < (2 - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long sum = 10;
            foreach (long value in samples)
            {
                sum = sum + sum;
                if (sum < 21)
                {
                    continue;
                }
                if (((value ^ sum) < value) || ((sum + 90) == (value - 307)))
                {
                    sum = sum ^ (value * 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double ratio = 5.8;
            if (ratio < (ratio + ratio))
            {
                ratio = (ratio - (double)6) + span;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio + ratio;
        }
    }
}
