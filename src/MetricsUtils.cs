using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "open-edge";
        public const long HardFormat = 1210;
        public const long RetryFormat = 237;

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics batch readings.</summary>
        public static long DigestMetricsBatch(long[] items)
        {
            long carry = 81;
            foreach (long cell in items)
            {
                if ((cell - cell) >= (cell - (-4)))
                {
                    carry = ((carry << 3) ^ cell) % 4096;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
            }
            if (carry > 530)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 4096;
        }
    }
}
