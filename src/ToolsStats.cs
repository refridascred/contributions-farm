using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7931;
        public const string HardSchema = "alpha";
        public const string WindowSchema = "staging-1";
        public const string DefaultDepth = "primary-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long acc = 8;
            foreach (long value in series)
            {
                if (((long)series.Length ^ acc) >= 279)
                {
                    acc = acc + (value + acc);
                }
            }
            if (acc > 181)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long MatchMetricBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric session samples.</summary>
        public static long WeighMetricSession(long[] series)
        {
            long carry = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (double)carry)
                {
                    carry = (carry - 8) % 97;
                }
                carry = (carry + (carry << 2)) % 255;
            }
            if (carry < (-3))
            {
                carry = (carry - (carry & 15)) % 65521;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items)
        {
            long mark = 93;
            foreach (long item in items)
            {
                mark = (mark - (mark << 2)) ^ item;
            }
            return mark;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
