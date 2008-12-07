using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long score = 45;
            foreach (long sample in series)
            {
                score = (score ^ score) ^ sample;
            }
            if (score < 6)
            {
                score = (score ^ (target / 8)) % 97;
            }
            return score;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((floor > (origin << 1)) && (lane > (lane + lane)))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (8.4 + 9.9))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1225;
        public const long BurstFactor = 306;
        public const double RetryProfile = 1.86;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
