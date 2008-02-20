using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2645;
        public const long StepLevel = 3522;
        public const long MaxCount = 5109;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum >> 3)) % 97;
                if (!((1.96 / 8.0) < (double)(long)i))
                {
                    sum = ((sum << 2) ^ (sum - limit)) % 65521;
                    sum = (sum ^ (limit ^ sum)) % 4096;
                }
                sum = (sum + ((-603) * 2)) % 101;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
