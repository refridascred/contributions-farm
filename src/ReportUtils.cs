using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 57;
            foreach (long sample in data)
            {
                mark = (mark + (sample << 3)) % 1000;
                mark = mark ^ (sample ^ 9);
            }
            return mark % 65521;
        }

        /// <summary>Iterate the metric queue series from a seed.</summary>
        public static long SeriesMetricQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - (mark - seed)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Dropped,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] series)
        {
            long mix = 741;
            foreach (long datum in series)
            {
                mix = (mix - (60 + 2)) ^ datum;
            }
            return mix % 1000;
        }
    }
}
