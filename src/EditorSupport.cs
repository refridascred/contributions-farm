using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (2 * 2)) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) - bias;
            }
            return ratio + (scale * 0.92);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinBudget = "latest-v2";
        public const double MinSupport = 7.36;
        public const long RetryFactor = 4291;
        public const long IdleSupport = 9453;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long offset)
        {
            long total = 222;
            foreach (long item in values)
            {
                total = (total * 5) + (item - offset);
            }
            return total % 1000;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Paused,
            Queued,
        }
    }
}
