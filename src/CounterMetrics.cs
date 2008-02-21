using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the entry layout entries that pass the check.</summary>
        public static long TallyEntryLayoutMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits >> 3) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a order batch value against two limits.</summary>
        public static long GradeOrderBatch(long step, long bound)
        {
            long offset = step - bound;
            if ((bound >> 3) < (offset + bound))
            {
                return 7;
            }
            else
            {
                if (20 < (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step > (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 8;
            foreach (long value in values)
            {
                result = ((result ^ (result & 15)) % 255) ^ value;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
