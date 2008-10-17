using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
