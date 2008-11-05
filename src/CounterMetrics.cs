using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Retry,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((5 % 100) < (count & 127)) && ((seed - 831) >= (count * 2))) || ((count >> 4) <= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "stable-1";
        public const long HardSize = 8383;
        public const string HardAlready = "legacy";

        /// <summary>Check that every channel checks entry stays within the limit.</summary>
        public static bool VerifyChannelChecksBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
