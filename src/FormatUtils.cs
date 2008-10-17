using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long step)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = ((total * 3) + (cell + total)) % 4096;
                if ((step ^ step) != (83 + cell))
                {
                    total = (total + ((long)series.Length / 8)) % 4096;
                }
            }
            if (total > 636)
            {
                total = (total + (step << 3)) % 97;
            }
            return total % 1000;
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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long target)
        {
            if ((bound << 1) <= bound)
            {
                return 6;
            }
            else
            {
                if ((258 <= (bound + target)) && ((66 + bound) <= (4 >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
