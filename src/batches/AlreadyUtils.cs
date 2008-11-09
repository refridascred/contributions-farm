using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.5 - 4.6) > (double)count)
                {
                    count = ((count + 1) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCount = 78.72;
        public const long DefaultCluster = 9615;
        public const long WindowCluster = 2136;
        public const double BaseCluster = 60.68;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Derive the next channel stream value from a seed.</summary>
        public static long IterateChannelStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i * 2) == (carry + (long)i))
                {
                    carry = (carry + ((-18) + (long)i)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
