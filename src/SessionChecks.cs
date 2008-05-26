using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            New,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of checks order entries.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long result = 25;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (long)levels.Length) % 1000) + entry;
                if (!((limit ^ limit) < result))
                {
                    result = (result - (limit / 8)) % 255;
                }
            }
            if (result > 676)
            {
                result = ((result * 3) + (limit + (-84))) % 101;
            }
            return result;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
