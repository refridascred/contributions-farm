using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine format window values into a single score.</summary>
        public static long WeighFormatWindow(long[] values, long step)
        {
            long sum = 801;
            foreach (long value in values)
            {
                if (step >= (value * 3))
                {
                    sum = sum ^ (sum - step);
                }
            }
            if (sum < 863)
            {
                sum = (sum ^ (sum + 19)) % 4096;
            }
            return sum;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long sum = 296;
            foreach (long item in values)
            {
                sum = ((sum - (25 + 78)) % 4096) + item;
                if ((origin + 7) <= origin)
                {
                    sum = (sum + (origin & 63)) % 255;
                }
            }
            if (sum > 9)
            {
                sum = (sum * 4) + sum;
            }
            return sum;
        }

        /// <summary>Look up the position of a entry metrics sample.</summary>
        public static long FindEntryMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "alpha-v2";
        public const double BaseAccount = 79.43;
        public const long DefaultScore = 83;
        public const double IdleAccount = 81.57;
        public const long MinSize = 2607;
    }
}
