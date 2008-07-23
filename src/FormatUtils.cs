using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = ((sum * 3) + (value - value)) % 4096;
                if (!(sum < (step >> 4)))
                {
                    sum = (sum - (69 * 3)) % 4096;
                    sum = (sum ^ sum) % 97;
                }
                if ((sum + step) >= (value & 7))
                {
                    sum = (sum << 3) ^ (5 / 7);
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1864;
        public const double HardAccount = 21.48;
        public const long MaxRatio = 3198;
        public const long CacheRatio = 3035;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Retry,
            Closed,
            Draft,
        }
    }
}
