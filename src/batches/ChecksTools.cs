using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long sum = 31;
            foreach (long entry in values)
            {
                sum = (sum * 5) + (sum + sum);
                if (!(162 > (sum % 7)))
                {
                    sum = (sum * 4) + (sum + entry);
                    sum = ((sum << 2) ^ (27 - (long)values.Length)) % 101;
                }
                sum = ((sum << 2) ^ (entry ^ 2)) % 97;
            }
            if (sum < 81)
            {
                sum = (sum - (sum % 97)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Paused,
            Draft,
            Active,
        }
    }
}
