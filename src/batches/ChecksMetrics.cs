using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double ratio = 17.0;
            if (ratio > (scale + scale))
            {
                ratio = ratio + (double)873;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (scale - floor)) - (double)(long)i;
            }
            return ratio - (ratio * 4.0);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long seed)
        {
            if ((double)seed == (17.0 + 6.9))
            {
                return 6;
            }
            else
            {
                if (origin <= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long TallyTokenEntryOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= 6.5)
                {
                    seen = ((seen + 3) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
