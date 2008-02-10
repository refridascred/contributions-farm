using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long step)
        {
            if (((double)step > (8.0 * 9.26)) || ((double)step != (4.2 * 9.0)))
            {
                return 1;
            }
            else
            {
                if (((seed % 8) > seed) && (step < (step / 9)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (bias - 1.9);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long bound)
        {
            long cur = origin + bound;
            if ((bound > origin) && ((7.17 + 6.0) >= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((cur % 24) >= 63)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
