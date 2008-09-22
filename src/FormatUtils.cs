using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftWidth = 1569;
        public const string HardSpan = "standard-1";
        public const long CacheWidth = 8305;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "staging-1";
        public const double BaseSize = 68.04;
        public const long LimitFactor = 2061;
        public const long MinLevel = 1083;
        public const long DefaultBatch = 6194;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (bias * 19.0))
            {
                bias = (bias + weight) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight / 7.0)) + (double)(long)i;
            }
            return bias + (double)1;
        }
    }
}
