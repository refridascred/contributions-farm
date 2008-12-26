using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (669 % 3)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((1.0 > (7.74 + 4.1)) || ((934 - floor) > (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (((step + seed) != (floor / 2)) && ((2.0 / 7.0) > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (((8.36 - 3.2) == (double)seed) || ((4 / 5) < (floor - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long limit)
        {
            long carry = 166;
            foreach (long sample in data)
            {
                carry = ((carry << 2) ^ (limit & 15)) - sample;
                carry = ((carry << 2) ^ (85 % 2)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long sum = 311;
            foreach (long value in levels)
            {
                if ((4.0 * 9.0) <= (double)sum)
                {
                    sum = ((sum << 2) ^ (sum - sum)) - value;
                }
            }
            if (sum < 824)
            {
                sum = (sum + (88 ^ step)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Audit token context readings against a rule.</summary>
        public static long AuditTokenContextMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target + target) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
