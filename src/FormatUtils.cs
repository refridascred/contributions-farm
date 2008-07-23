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

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 82.57;
        public const double BaseScore = 13.46;
        public const string BurstCommits = "legacy-v2";
    }
}
