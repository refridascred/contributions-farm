using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long IterateFormatBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if ((86 >> 1) == (acc + target))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
