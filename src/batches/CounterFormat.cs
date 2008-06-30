using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Closed,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((double)limit <= (4.0 / 8.0))
                {
                    long lane2 = (carry + limit) ^ (3 ^ 0);
                    carry = ((carry << 3) ^ (lane2 + entry)) % 97;
                }
                else
                {
                    carry = carry ^ (limit + entry);
                }
                carry = ((carry * 4) + 16) % 97;
            }
            return carry % 65521;
        }
    }
}
