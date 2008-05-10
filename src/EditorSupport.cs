using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count <= (long)data.Length)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total * 5) + (664 & 7)) % 101) ^ (long)i2;
                    total = total - (total ^ total);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ (offset ^ mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + 0) >= (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
