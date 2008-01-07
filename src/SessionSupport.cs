using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long origin)
        {
            long result = 28;
            foreach (long entry in data)
            {
                if ((result < entry) || ((double)entry >= (double)result))
                {
                    result = result ^ (origin / 6);
                }
            }
            if (result < 75)
            {
                result = (result * 3) + (9 - result);
            }
            return result;
        }
    }
}
