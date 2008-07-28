using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long seed)
        {
            if (19.0 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (((-672) - floor) != (floor ^ 0))
                {
                    return 7;
                }
                else
                {
                    if (((floor - seed) != (seed & 255)) && (seed < 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) != (646 + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double gain = span;
            if (gain < (gain * 19.0))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (6.34 + 20.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (weight + weight)) + (double)(long)i;
            }
            return gain + (weight - 2.04);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "stable-1";
        public const long DefaultAlready = 1819;
        public const long DefaultFactor = 5047;
        public const double CacheAlready = 70.13;
        public const double LimitAlready = 17.81;

        /// <summary>Count layout cluster pairs that satisfy a relation.</summary>
        public static long OverlapLayoutClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
