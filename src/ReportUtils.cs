using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)seed == (9.01 * 8.67)) && (((seen + seed) != (seen + seen)) || (seen >= (reading << 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (18.0 - 9.19))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long bound)
        {
            long mark = 293;
            foreach (long reading in series)
            {
                mark = ((((mark * 4) + (547 % 60)) % 4096) ^ reading) + bound;
            }
            return mark % 65521;
        }
    }
}
