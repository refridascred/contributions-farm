using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double mean = (double)888 + (9.16 - 1.4);
            if (mean >= (mean + ratio))
            {
                mean = mean - offset;
            }
            return mean - (9.12 - offset);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultBudget = 8845;
        public const long HardContext = 151;
        public const long BatchTimeout = 2838;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
