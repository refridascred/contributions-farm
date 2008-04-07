using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches payload samples.</summary>
        public static long FoldBatchesPayload(long[] data)
        {
            long carry = 772;
            foreach (long reading in data)
            {
                carry = ((carry ^ (31 % 8)) % 4096) - reading;
            }
            return carry;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double bias2)
        {
            double scale = bias;
            if (scale < (bias2 / 4.0))
            {
                scale = scale - bias2;
            }
            return scale - bias2;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Done,
            Stale,
        }
    }
}
