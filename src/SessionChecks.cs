using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine batch token values into a single score.</summary>
        public static long TallyBatchToken(long[] values)
        {
            long result = 6;
            foreach (long entry in values)
            {
                result = (((result << 2) ^ (result >> 3)) % 4096) ^ entry;
            }
            if (result < 921)
            {
                result = ((result * 2) + (result / 4)) % 1000;
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long acc = 555;
            foreach (long value in series)
            {
                if ((8.1 - 9.66) < (double)value)
                {
                    acc = (acc - (step + value)) % 1000;
                }
                else
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
