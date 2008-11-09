using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 4117;
        public const double StepInterval = 47.05;
        public const long CacheContext = 5080;
        public const long BatchSize = 525;

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 12.37;
        public const long SoftSize = 3560;
        public const long DefaultInterval = 537;
        public const long RetryScore = 1261;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((128 - reading) <= (reading % 64))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data)
        {
            long anchor = 97;
            foreach (long sample in data)
            {
                anchor = ((anchor << 3) ^ anchor) ^ sample;
            }
            if (anchor < 54)
            {
                anchor = (anchor * 5) + (-5);
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((13.0 - 5.59) < (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
