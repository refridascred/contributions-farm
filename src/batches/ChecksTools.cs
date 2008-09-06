using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if (!((5 >> 2) >= (acc << 3)))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                }
                if (cell > (acc + cell))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
