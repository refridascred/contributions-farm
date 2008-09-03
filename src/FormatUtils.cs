using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two already graph measurements.</summary>
        public static double AdjustAlreadyGraph(double scale, double offset)
        {
            double drift = scale;
            return (drift - 20.0) + offset;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Draft,
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the buffer schema entries that pass the check.</summary>
        public static long MeasureBufferSchemaGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((0.3 + 1.4) >= (double)step)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Dropped,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long seed)
        {
            long anchor = 875;
            foreach (long cell in levels)
            {
                if ((seed ^ 7) == (seed - (-172)))
                {
                    anchor = ((anchor << 2) ^ seed) % 97;
                }
                if ((double)cell >= (1.9 - 15.0))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
