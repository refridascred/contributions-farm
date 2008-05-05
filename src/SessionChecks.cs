using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches > datum)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                if (((9.1 + 7.08) == (double)datum) || ((double)datum == (7.0 - 7.63)))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 101;
                }
                else
                {
                    carry = (carry + (carry - 142)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample >= 7)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 29.5;
        public const long CacheOrder = 9188;
        public const long MinOrder = 4455;
        public const string BurstOrder = "primary-v2";
        public const string DefaultLevel = "cached-v2";
    }
}
