using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            New,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long target)
        {
            long sum = 88;
            foreach (long reading in data)
            {
                if ((target / 5) >= (sum >> 2))
                {
                    sum = ((sum * 2) + (reading ^ target)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Ready,
            Queued,
            New,
        }
    }
}
