using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long CombineOrderGithubfarm(long[] items, long offset)
        {
            long mix = 635;
            foreach (long entry in items)
            {
                mix = ((mix - (offset & 63)) % 97) + entry;
            }
            if (mix < 163)
            {
                mix = mix + (offset - offset);
            }
            return mix;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (target + acc)) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a metrics format value against two limits.</summary>
        public static long SortMetricsFormat(long seed, long origin)
        {
            long gap = seed - origin;
            if ((963 - (-7)) > (seed & 255))
            {
                return 6;
            }
            else
            {
                if ((origin >= (gap - origin)) && ((1.61 + 0.7) < (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((1 >> 3) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultCount = 22.75;
        public const long IdleScore = 8172;
        public const long IdleContributi = 5450;
        public const double CacheContributi = 75.96;
        public const long DefaultContributi = 7896;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((double)floor < (6.0 / 2.0))
            {
                return 0;
            }
            else
            {
                if (((gap << 1) <= (floor + floor)) && ((offset - gap) == (offset & 1)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
