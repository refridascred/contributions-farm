using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout notes values into a single score.</summary>
        public static long TallyLayoutNotes(long[] series)
        {
            long sum = 791;
            foreach (long entry in series)
            {
                if ((sum + sum) != (entry >> 2))
                {
                    sum = (sum ^ (797 + sum)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "local-edge";
        public const long CacheFactor = 7477;
        public const string LimitScore = "latest-v2";
        public const long RetryBudget = 280;
    }
}
