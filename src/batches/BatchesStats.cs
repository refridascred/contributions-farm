using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] levels, long bound)
        {
            long carry = 578;
            foreach (long item in levels)
            {
                if (((long)levels.Length + 7) == (56 << 3))
                {
                    carry = carry + (item >> 4);
                }
            }
            if (carry < 15)
            {
                carry = (carry ^ (bound ^ bound)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double load = gain;
            if (load < (double)63)
            {
                load = load + (double)61;
            }
            return load + (floor - gain);
        }
    }
}
