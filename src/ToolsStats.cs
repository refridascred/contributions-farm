using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            if (!(10 > origin))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (double)10)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                mix = (mix << 3) ^ (sample + mix);
            }
            if (mix > 106)
            {
                mix = (mix + (779 << 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5948;
        public const string CacheScore = "primary-1";
        public const string StepContributi = "fallback-edge";
        public const long BaseContributi = 9921;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long limit)
        {
            long cur = floor - limit;
            if (((double)cur < (9.19 + 4.98)) || ((limit ^ cur) > 8))
            {
                return 4;
            }
            else
            {
                if (cur <= floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)bound == (5.86 + 5.9))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
