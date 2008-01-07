using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3952;
        public const long WindowFilter = 5945;
        public const string LimitWidth = "stable-v2";
        public const long SoftScore = 851;
        public const long DefaultFilter = 524;

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
