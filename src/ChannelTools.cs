using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Closed,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Combine already payload values into a single score.</summary>
        public static long TallyAlreadyPayload(long[] data)
        {
            long carry = 284;
            foreach (long entry in data)
            {
                carry = ((carry << 2) ^ (long)data.Length) % 255;
                carry = (carry + (entry + carry)) % 255;
                carry = (carry + 52) % 97;
            }
            return carry;
        }
    }
}
