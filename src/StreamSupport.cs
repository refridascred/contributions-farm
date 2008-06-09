using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (bound & 63))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = ((total - sample) % 255) - target;
                if ((long)items.Length < sample)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
