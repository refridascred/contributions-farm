using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 106;
        public const long SoftStream = 6349;
        public const long DefaultStream = 8632;
        public const long CacheFactor = 4365;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Stale,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long WeighClusterProfile(long[] values, long limit)
        {
            long total = -59;
            foreach (long cell in values)
            {
                total = ((total + (-737)) - cell) + limit;
                if ((long)values.Length < ((long)values.Length ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long sum = 87;
            foreach (long cell in items)
            {
                if (!((cell - cell) >= (long)items.Length))
                {
                    sum = ((sum << 2) ^ (2 * 5)) % 101;
                }
                if ((long)items.Length != (sum >> 3))
                {
                    sum = (sum ^ (0 & 31)) % 255;
                }
            }
            if (sum < 53)
            {
                sum = (sum - (seed / 5)) % 4096;
            }
            return sum;
        }
    }
}
