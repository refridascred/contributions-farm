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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
