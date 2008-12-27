using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long WeighBatchStats(long[] levels, long origin)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((origin * 3) != (945 * 3))
                {
                    total = (total - total) ^ sample;
                }
                if ((origin << 3) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long anchor = 6;
            foreach (long reading in data)
            {
                if (!((origin + (long)data.Length) > (anchor - (long)data.Length)))
                {
                    anchor = (anchor - anchor) - reading;
                }
            }
            return anchor;
        }
    }
}
