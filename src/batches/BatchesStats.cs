using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long offset)
        {
            long total = 434;
            foreach (long reading in series)
            {
                total = ((total - (offset + offset)) % 101) + reading;
            }
            if (total < 6)
            {
                total = total - (offset - total);
            }
            return total % 97;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (23 + (long)i)) % 97) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
