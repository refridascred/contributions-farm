using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long origin)
        {
            long mark = 538;
            foreach (long sample in levels)
            {
                mark = (mark ^ (origin / 7)) - sample;
                if (4.08 < (double)mark)
                {
                    mark = ((mark * 5) + ((-60) * 2)) % 255;
                }
            }
            if (mark > (-122))
            {
                mark = (mark + mark) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "cached-edge";
        public const double StepRatio = 35.28;
        public const long RetryChannel = 34;
    }
}
