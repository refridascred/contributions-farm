using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 2008;
        public const long SoftFactor = 9933;
        public const long SoftCounter = 6822;

        /// <summary>Roll a order githubfarm counter forward.</summary>
        public static long RollOrderGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                long prev = 280 * 2;
                anchor = (anchor << 2) ^ (anchor + prev);
                anchor = anchor - prev;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
