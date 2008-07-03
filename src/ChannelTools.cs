using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i >> 3) != (target % 24))
                {
                    carry = (carry * 5) + (carry / 2);
                }
                else
                {
                    carry = carry - target;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((7 / 9) >= (offset & 31)) && (((double)offset == (5.0 * 8.4)) || ((6 ^ offset) < offset)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
