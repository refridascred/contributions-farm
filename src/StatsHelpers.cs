using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 558;
            foreach (long entry in readings)
            {
                if (((result - entry) > entry) && ((16.0 + 13.0) < (double)result))
                {
                    result = (result + ((long)readings.Length + result)) % 4096;
                }
            }
            if (result > 2)
            {
                result = ((result * 5) + (45 * 4)) % 101;
            }
            return result % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryLevel = 7199;
        public const long RetryRecord = 7202;
        public const long StepFactor = 1062;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Active,
            Idle,
        }
    }
}
