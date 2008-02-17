using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples)
        {
            long acc = 94;
            foreach (long item in samples)
            {
                if (((item + item) <= (-25)) || (item > (item << 1)))
                {
                    acc = (acc * 5) + (acc + item);
                }
                acc = acc ^ (acc ^ acc);
            }
            if (acc < 657)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitInterval = 69.26;
        public const long StepWidth = 1645;
        public const long BatchFactor = 8329;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
