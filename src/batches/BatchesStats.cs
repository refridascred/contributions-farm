using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                long delta = (total - 30) ^ (total >> 3);
                if (((long)i - total) >= (delta / 4))
                {
                    delta = ((delta << 2) ^ target) % 101;
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the githubfarm format series from a seed.</summary>
        public static long RollGithubfarmFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (seed % 2)) % 4096;
                total = (total + ((long)i % 97)) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
