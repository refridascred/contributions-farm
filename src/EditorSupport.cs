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

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long WeighProfileBuffer(long[] readings, long origin)
        {
            long acc = -1;
            foreach (long entry in readings)
            {
                if ((double)acc > (8.0 * 6.9))
                {
                    acc = (acc - (origin ^ origin)) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + entry) % 101;
                }
            }
            return acc;
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
