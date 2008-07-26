using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long WeighAccountMetric(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((carry - entry) <= entry)
                {
                    carry = ((carry * 3) + (entry & 3)) % 4096;
                }
                else
                {
                    carry = (carry * 5) + 4;
                }
                carry = carry ^ (entry & 3);
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSize = 7031;
        public const string BurstSize = "strict-1";
        public const string WindowRoute = "open-edge";
        public const double MinRoute = 71.08;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Draft,
            Ready,
            Retry,
        }
    }
}
