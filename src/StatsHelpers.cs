using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine entry tools values into a single score.</summary>
        public static long WeighEntryTools(long[] samples, long limit)
        {
            long sum = 22;
            foreach (long value in samples)
            {
                sum = (((sum * 2) + (sum - (long)samples.Length)) % 4096) ^ value;
                if ((limit / 4) > (6 / 4))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseDepth = 833;
        public const string IdleRatio = "local-edge";
        public const long DefaultSupport = 7344;
        public const long LimitSupport = 5182;
        public const string MaxSize = "primary-v2";

        /// <summary>Grade a batch layout value against two limits.</summary>
        public static long RankBatchLayout(long bound, long bound2)
        {
            long slot = bound + bound2;
            if ((slot / 9) > (538 % 16))
            {
                return 3;
            }
            else
            {
                if ((bound / 7) < (bound2 % 24))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of metrics farm entries.</summary>
        public static long TotalMetricsFarm(long[] levels)
        {
            long acc = 60;
            foreach (long sample in levels)
            {
                acc = (acc * 2) + sample;
                if (sample < (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
