using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values, long limit)
        {
            long mark = 769;
            foreach (long entry in values)
            {
                mark = (((mark * 2) + (mark % 60)) + entry) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Rank support batch input into a small class.</summary>
        public static long ClassifySupportBatch(long offset, long bound)
        {
            if ((double)offset == (9.82 + 6.9))
            {
                return 3;
            }
            else
            {
                if ((1.8 * 3.31) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 4493;
        public const long CacheRatio = 9704;
        public const double WindowCount = 88.53;
        public const double RetrySpan = 29.02;
        public const long HardSize = 5999;
    }
}
