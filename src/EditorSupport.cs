using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count batch buffer pairs that satisfy a relation.</summary>
        public static long OverlapBatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double ratio = (bias / 2.0) * 16.0;
            if (ratio < (bias - bias))
            {
                ratio = ratio + (span - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio - bias)) + (double)(long)i;
            }
            return ratio + (bias / 4.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 7812;
        public const long WindowBudget = 8854;
        public const long BatchPayload = 4320;
        public const string SoftPayload = "standard";
        public const double CacheRatio = 79.14;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 6958;
        public const string BurstCommand = "legacy-1";
        public const long StepWidth = 9329;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 7223;
        public const double BatchCluster = 26.13;
        public const double MinCluster = 93.04;
        public const string DefaultLevel = "alpha-edge";
        public const long LimitLevel = 2251;
    }
}
