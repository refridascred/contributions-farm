using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 670;
            foreach (long datum in samples)
            {
                if ((624 & 255) >= datum)
                {
                    result = ((result * 2) + (datum + datum)) % 101;
                }
                else
                {
                    result = result - (datum / 3);
                }
            }
            if (result > 88)
            {
                result = ((result << 2) ^ (-67)) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1665;
        public const double LimitCommand = 77.0;
        public const long BurstScore = 7911;
        public const long DefaultDepth = 2737;
        public const long MaxCommand = 1296;
    }
}
