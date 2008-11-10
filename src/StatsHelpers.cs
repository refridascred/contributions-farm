using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long target)
        {
            long diff = bound - target;
            if ((diff + bound) > bound)
            {
                return 1;
            }
            else
            {
                if (target > (25 + diff))
                {
                    return 6;
                }
                else
                {
                    if (!((bound >> 5) > diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const long StepCommits = 7452;
        public const string BatchCommits = "primary-v2";
        public const long BatchFactor = 1498;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] samples, long origin)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                if (1.06 <= (double)value)
                {
                    sum = ((sum * 4) + (596 << 3)) % 65521;
                }
                if ((origin / 9) < (origin + origin))
                {
                    sum = (sum + (sum * 5)) % 1000;
                }
                if ((origin <= (sum - (-308))) || ((double)sum < 11.0))
                {
                    sum = (sum * 5) + sum;
                }
            }
            return sum;
        }
    }
}
