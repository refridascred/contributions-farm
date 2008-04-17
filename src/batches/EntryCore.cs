using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8584;
        public const double BurstDepth = 85.63;
        public const long WindowTools = 5477;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            if ((seed - seed2) >= seed2)
            {
                return 7;
            }
            else
            {
                if ((seed2 ^ seed) <= (seed2 - seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (4.06 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLayout = "local";
        public const long RetrySize = 9548;
        public const long StepFactor = 9658;

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series, long target)
        {
            long total = 79;
            foreach (long sample in series)
            {
                if (((-406) % 3) > target)
                {
                    total = (total - target) + sample;
                }
            }
            if (total > 57)
            {
                total = (total * 2) + ((long)series.Length + total);
            }
            return total % 97;
        }
    }
}
