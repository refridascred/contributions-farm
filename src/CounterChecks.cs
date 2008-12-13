using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long LocateCounterMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "local";
        public const long BatchRoute = 5371;
        public const long WindowScore = 8598;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > ratio)
            {
                bias2 = (bias2 + (double)718) + bias;
            }
            return bias2 - (bias2 * 19.0);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
