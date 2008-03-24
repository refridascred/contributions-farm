using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels, long origin)
        {
            long acc = 261;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length >= (6.0 - 2.0))
                {
                    acc = acc + (cell / 9);
                }
                else
                {
                    acc = (acc ^ (cell / 6)) % 1000;
                }
                if (origin > (acc + origin))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((hits + hits) > 6) && ((cell - hits) > ((long)values.Length % 2))) || ((double)hits < 5.1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryFactor = "primary";
        public const long BurstDepth = 5823;
        public const long StepLayout = 367;
        public const long BurstCount = 7795;
    }
}
