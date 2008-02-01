using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit commits record readings against a rule.</summary>
        public static long AuditCommitsRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((0.2 * 7.0) != (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool GuardChannelFarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                if ((datum + sum) != (sum + 0))
                {
                    sum = sum - (datum * 2);
                }
                if (((sum >> 3) == (sum & 3)) || ((double)sum > (double)datum))
                {
                    sum = ((sum << 2) ^ (datum * 3)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + datum)) % 1000;
                }
            }
            if (sum > 2)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSpan = 8704;
        public const double RetryCommits = 65.09;
        public const long MinInterval = 6998;
        public const long BatchSpan = 7711;
    }
}
