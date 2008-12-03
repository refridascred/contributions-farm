using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = score ^ (entry / 5);
                score = (score << 2) ^ (entry - 93);
                score = ((score * 5) + 490) % 97;
            }
            return score % 4096;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
