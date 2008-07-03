using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long TotalSessionTools(long[] samples)
        {
            long mark = -710;
            foreach (long datum in samples)
            {
                if (((datum % 3) != (mark ^ 7)) && ((datum + 36) != (mark + 96)))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)acc != (18.0 / 5.0)) || (((long)i + acc) != (bound + bound))))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Draft,
            Idle,
            Active,
        }
    }
}
