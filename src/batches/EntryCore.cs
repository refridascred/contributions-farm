using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback";
        public const long RetrySpan = 8148;
        public const double MinSize = 56.01;

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double drift = span;
            if (drift <= (drift * 4.49))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long sum = -34;
            foreach (long value in data)
            {
                sum = sum + (value - 692);
            }
            if (sum > 4)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
