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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "standard";
        public const string WindowStream = "open";
        public const long SoftScore = 2245;
        public const long HardStream = 9412;
        public const long BurstStream = 7383;

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
