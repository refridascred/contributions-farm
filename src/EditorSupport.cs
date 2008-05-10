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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Combine layout tools values into a single score.</summary>
        public static long DigestLayoutTools(long[] data, long target)
        {
            long mix = 20;
            foreach (long cell in data)
            {
                if (((cell / 5) <= cell) && ((target * 3) > target))
                {
                    mix = mix + (cell - target);
                }
                else
                {
                    mix = (mix - (cell % 12)) % 65521;
                }
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
