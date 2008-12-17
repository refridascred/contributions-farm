using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 9653;
        public const long WindowBatches = 9597;
        public const string BaseCount = "strict-edge";
        public const long DefaultSize = 3115;
        public const long StepScore = 1363;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long bound)
        {
            long mark = 63;
            foreach (long cell in readings)
            {
                if ((cell <= (109 - 60)) || (1.9 < (double)bound))
                {
                    mark = (mark << 3) ^ (cell % 16);
                }
            }
            return mark;
        }

        /// <summary>Rank tools batch input into a small class.</summary>
        public static long BucketToolsBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((8.55 + 2.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((step ^ cur) < (7 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
