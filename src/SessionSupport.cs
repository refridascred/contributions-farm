using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (origin + anchor)) % 1000;
                if (!((double)anchor > (double)60))
                {
                    anchor = (anchor << 2) ^ (7 * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 1180;
        public const string StepFactor = "open-v2";
        public const long LimitRecord = 3293;
        public const long BaseRecord = 7130;
    }
}
