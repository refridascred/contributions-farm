using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double weight = (double)(9 >> 5);
            if (weight <= bias)
            {
                weight = weight + (double)763;
            }
            else
            {
                weight = weight - (floor - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (4.1 / 8.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            long edge = seed + offset;
            if (!(edge >= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (7.0 - 2.33))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stats order readings.</summary>
        public static long TallyStatsOrder(long[] samples)
        {
            long result = 0;
            foreach (long sample in samples)
            {
                result = (((result * 5) + (945 << 1)) % 65521) ^ sample;
            }
            return result % 97;
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long MeasureAlreadyAccountOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) == (sample ^ matches))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long limit)
        {
            if (floor >= (floor & 3))
            {
                return 3;
            }
            else
            {
                if ((limit + 85) >= (limit + 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
