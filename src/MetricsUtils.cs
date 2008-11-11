using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Failed,
            New,
            Pending,
        }

        /// <summary>Compare every pair of editor profile readings.</summary>
        public static long CompareEditorProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((target << 2) == (target ^ (long)values.Length)) && (target >= (item << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((1.5 + 0.44) > (double)offset)
            {
                return 5;
            }
            else
            {
                if ((floor <= (39 + offset)) && (offset < (slot & 255)))
                {
                    return 3;
                }
                else
                {
                    if ((offset - slot) > (303 / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
