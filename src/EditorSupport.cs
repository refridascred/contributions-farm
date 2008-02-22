using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (bound * 3))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= ((long)data.Length + 8)) || ((double)limit < (9.1 + 3.6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long acc = -2;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ step) % 4096) + entry;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seed >= (seed * 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context farm samples are out of range.</summary>
        public static long MeasureContextFarmHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)origin != (9.6 + 17.0))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
