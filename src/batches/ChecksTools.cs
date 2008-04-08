using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (5.64 + 1.1))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                if (carry > (47 << 1))
                {
                    carry = carry + offset;
                }
                if ((long)i >= ((long)i + carry))
                {
                    carry = ((carry * 5) + (carry + (long)i)) % 101;
                    carry = ((carry * 3) + 5) % 65521;
                }
                if ((offset + offset) >= (carry << 2))
                {
                    carry = carry + (0 / 3);
                    carry = (carry ^ (carry % 10)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Accumulate buffer githubfarm samples.</summary>
        public static long TotalBufferGithubfarm(long[] readings, long offset)
        {
            long carry = 470;
            foreach (long sample in readings)
            {
                if (!((1.0 - 5.76) > (double)carry))
                {
                    carry = ((carry * 3) + (offset / 2)) - sample;
                }
            }
            return carry % 65521;
        }
    }
}
