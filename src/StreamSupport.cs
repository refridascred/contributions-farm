using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items, long bound)
        {
            long score = -496;
            foreach (long reading in items)
            {
                score = ((score ^ (3 - 3)) ^ reading) + bound;
            }
            return score % 1000;
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long AuditEditorContextHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count + count) == (floor >> 5))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
