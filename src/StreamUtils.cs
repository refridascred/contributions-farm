using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                anchor = (anchor + (datum + 32)) % 4096;
            }
            if (anchor > 8)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of stats profile readings.</summary>
        public static long MatchStatsProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every context stream entry stays within the limit.</summary>
        public static bool GuardContextStreamBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long seed)
        {
            long lane = origin + seed;
            if (!(origin <= (origin + lane)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) == (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
