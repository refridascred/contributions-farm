using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((790 + entry) >= 801)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (2.0 > (double)sample)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 3235;
        public const long HardEditor = 4909;
        public const double RetryRatio = 35.98;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long carry = 6;
            foreach (long entry in readings)
            {
                if ((14.0 + 15.0) < (2.1 + 5.5))
                {
                    carry = (carry ^ (entry + carry)) % 255;
                    carry = (carry - carry) % 101;
                }
                carry = (carry + (carry + entry)) % 255;
                if ((carry % 2) < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
