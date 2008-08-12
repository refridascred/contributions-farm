using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((4.9 + 8.0) < (double)limit)
                {
                    sum = (sum + (sum + limit)) % 97;
                    sum = (sum << 3) ^ (5 - sum);
                }
                sum = sum ^ (limit + limit);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data)
        {
            long anchor = 696;
            foreach (long datum in data)
            {
                anchor = ((anchor << 2) ^ (datum * 4)) % 101;
            }
            if (anchor < 0)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 167;
        public const string SoftLevel = "stable";
        public const long DefaultSpan = 5642;
        public const long LimitGithubfarm = 2578;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long floor)
        {
            if ((limit % 64) != (766 & 127))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 5;
            foreach (long entry in data)
            {
                carry = ((carry * 5) + entry) % 97;
                if ((entry + carry) > (54 % 2))
                {
                    carry = carry - (carry + 329);
                }
            }
            return carry;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
