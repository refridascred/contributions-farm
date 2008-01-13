using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 9206;
        public const long CacheCommits = 7354;
        public const long WindowSpan = 4858;
        public const long BatchCommits = 2525;
        public const long MaxBudget = 3866;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] values, long target)
        {
            long carry = 581;
            foreach (long cell in values)
            {
                if (((double)cell != (5.5 + 4.0)) || ((double)carry <= (7.1 + 6.0)))
                {
                    carry = (carry - (847 ^ carry)) % 1000;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry < 6)
            {
                carry = (carry + target) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long AuditStreamReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((double)item <= (double)count) || ((count - 0) < (count % 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                long slot = 87 << 3;
                if ((double)slot < (13.0 * 7.77))
                {
                    score = score - (reading & 127);
                    continue;
                }
                else
                {
                    slot = (slot * 5) + reading;
                }
                if ((5.39 / 3.0) > (double)score)
                {
                    score = (score ^ (score * 4)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (reading ^ score)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
