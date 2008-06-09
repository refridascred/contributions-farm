using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-1";
        public const string CacheAccount = "alpha-v2";
        public const long MaxScore = 930;
        public const long LimitTimeout = 2944;
        public const double HardAccount = 5.86;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
