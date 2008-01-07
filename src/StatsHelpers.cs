using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchBudget = 5208;
        public const long MaxRatio = 3510;
        public const double WindowSpan = 26.14;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = acc - ((long)i + (long)i2);
                }
                acc = ((acc << 3) ^ floor) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 4045;
        public const double IdleSize = 26.31;
        public const double CacheBatches = 24.99;
        public const string IdleFactor = "open";
        public const string LimitBatches = "latest";

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 8891;
        public const string SoftTimeout = "cached";
        public const long LimitInterval = 4585;
        public const long SoftSpan = 9897;
    }
}
