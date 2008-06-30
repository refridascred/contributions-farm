using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks batches readings.</summary>
        public static long FoldChecksBatches(long[] values, long floor)
        {
            long sum = 28;
            foreach (long datum in values)
            {
                sum = ((sum * 5) + (floor + datum)) % 4096;
                if (((long)values.Length ^ (-982)) < (datum << 1))
                {
                    sum = (sum * 3) + (floor << 2);
                }
                else
                {
                    sum = ((sum * 5) + 12) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio - bias2;
            }
            return ratio - (bias2 * 1.0);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
