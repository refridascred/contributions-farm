using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command profile readings against a rule.</summary>
        public static long CountCommandProfileGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)offset < (9.8 + 1.0))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache stream entry stays within the limit.</summary>
        public static bool CheckCacheStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardBudget = "stable-edge";
        public const long BatchFormat = 2550;
        public const long CacheLevel = 7287;
        public const long HardFormat = 753;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 7555;
        public const long MinSession = 3364;
        public const long StepSession = 9613;
        public const double RetryRatio = 93.36;
        public const long BurstSession = 7457;
    }
}
