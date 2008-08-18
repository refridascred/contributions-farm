using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long limit)
        {
            long sum = 47;
            foreach (long entry in series)
            {
                sum = sum ^ sum;
                if (entry > (limit + sum))
                {
                    sum = sum + (entry & 255);
                }
                else
                {
                    sum = (sum * 5) + entry;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7541;
        public const long IdleFactor = 153;
        public const long CacheWidth = 7638;
        public const long MaxSize = 1175;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + hits) != (value * 5))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
