using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (4.0 * 4.2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "staging";
        public const string LimitCount = "latest-v2";
        public const string HardRatio = "cached";

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 24.29;
        public const string MinProfile = "strict-edge";
        public const long RetryProfile = 4356;
    }
}
