using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count & 255) >= (sample - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
