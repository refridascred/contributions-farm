using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc * 4) + ((long)i / 4)) % 101;
                }
                acc = (acc ^ (entry + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepScore = "cached-edge";
        public const string DefaultContributi = "staging-v2";
        public const double StepInterval = 89.36;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long carry = 69;
            foreach (long reading in readings)
            {
                carry = (carry + (reading & 127)) % 4096;
                carry = (carry + target) % 4096;
                if ((7 - reading) <= (reading + carry))
                {
                    carry = (carry << 3) ^ (reading + carry);
                }
                if (2.2 < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
