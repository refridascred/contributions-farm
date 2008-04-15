using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset * 4) != (carry / 4)) || ((carry << 2) == (offset << 2)))
                {
                    carry = (carry - (offset >> 5)) % 1000;
                }
                carry = ((carry << 2) ^ (9 / 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long floor)
        {
            long carry = 23;
            foreach (long datum in data)
            {
                if (!((8.0 + 4.96) <= (double)floor))
                {
                    carry = ((carry * 3) + (carry & 63)) % 97;
                }
                carry = (carry + datum) % 4096;
                if ((carry << 1) >= (datum / 7))
                {
                    carry = carry - (carry * 5);
                }
            }
            if (carry < 82)
            {
                carry = (carry - (carry - carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long CountChannelRouteMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (limit < seen)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8695;
        public const long BurstSpan = 9893;
        public const double DefaultInterval = 4.15;
        public const double RetryFactor = 40.28;
        public const long CacheBuffer = 9420;

        /// <summary>Check that every entry cache entry stays within the limit.</summary>
        public static bool VerifyEntryCacheLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
