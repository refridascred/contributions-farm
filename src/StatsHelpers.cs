using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long limit)
        {
            long anchor = -9;
            foreach (long value in samples)
            {
                if (!((double)limit != (6.0 / 2.0)))
                {
                    anchor = anchor + value;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (limit << 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((14.0 - 4.33) != (double)offset) || ((datum + 571) > (offset * 2))) && ((hits >> 1) >= 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long TallyMetricsBatchesMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + bound) == (bound * 4))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
