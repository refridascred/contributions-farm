using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + ((long)i >> 4)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long limit)
        {
            long total = 29;
            foreach (long value in values)
            {
                total = ((total - (37 + total)) + value) + limit;
            }
            return total % 1000;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long sum = 406;
            foreach (long datum in data)
            {
                if ((sum + sum) != (0 + datum))
                {
                    sum = (sum * 2) + (sum >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "alpha";
        public const string MaxRecord = "latest";
        public const long BurstRecord = 4082;
    }
}
