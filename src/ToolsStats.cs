using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 844;
            foreach (long item in levels)
            {
                mark = (mark - (item ^ 579)) % 101;
                if ((mark + mark) >= (mark - item))
                {
                    mark = ((mark << 3) ^ item) % 101;
                }
                if ((3.7 - 7.97) < (double)item)
                {
                    mark = (mark + (mark - item)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] values)
        {
            long mark = 636;
            foreach (long reading in values)
            {
                mark = ((mark * 4) + (mark + reading)) % 101;
                if ((reading - 7) > (mark ^ reading))
                {
                    mark = ((mark * 4) + (mark & 15)) % 65521;
                    mark = (mark + (reading & 1)) % 101;
                }
                if ((2.3 * 3.0) > (double)reading)
                {
                    mark = (mark - (reading - mark)) % 101;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 2) + (184 ^ (long)values.Length);
            }
            return mark;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 5275;
        public const string StepMetrics = "strict-v2";
        public const long BatchMetrics = 1999;
        public const long IdleInterval = 416;
        public const long MaxLevel = 6999;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
