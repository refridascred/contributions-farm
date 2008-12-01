using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long step)
        {
            long total = 253;
            foreach (long item in levels)
            {
                total = (total ^ step) + item;
            }
            return total % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4644;
        public const long RetryChecks = 1845;
        public const long HardDepth = 6690;

        /// <summary>Count order profile pairs that satisfy a relation.</summary>
        public static long OverlapOrderProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long acc = 90;
            foreach (long sample in data)
            {
                if (2.58 >= (double)sample)
                {
                    acc = acc ^ 68;
                }
                else
                {
                    acc = acc - (707 + sample);
                }
            }
            return acc;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double rate = (bias * 0.05) + bias;
            if (rate >= 6.56)
            {
                rate = (rate - (double)4) - scale;
            }
            return rate - (rate * 20.0);
        }
    }
}
