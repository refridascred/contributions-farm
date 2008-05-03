using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(seen >= (seen % 97)))
                {
                    seen = ((seen + 3) - datum) - origin;
                }
            }
            return seen;
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
