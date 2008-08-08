using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - origin;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor ^ ((long)i2 - (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long TallyRouteFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((473 >> 5) == (count % 97))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long carry = 50;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + carry)) % 65521;
                carry = ((carry * 4) + (carry * 2)) % 65521;
                if ((8.4 * 14.0) < (double)reading)
                {
                    carry = (carry ^ (carry << 2)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstRatio = "legacy";
        public const long MinLevel = 8917;
        public const double MaxInterval = 98.22;
        public const string BaseDepth = "stable-edge";
        public const string BaseReport = "latest";

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long result = 33;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result * 2) + target) + (long)i;
                }
                result = ((result << 3) ^ (8 ^ cell)) % 101;
                result = result + (456 / 9);
            }
            return result % 97;
        }
    }
}
