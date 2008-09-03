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

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
