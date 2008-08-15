using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long CountEditorStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((32 >> 5) == (origin + (long)series.Length))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultInterval = "cached-1";
        public const string BatchCount = "standard";
        public const double MaxOrder = 46.88;
        public const double BatchDepth = 43.41;
        public const double MinCount = 37.51;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data, long limit)
        {
            long sum = 404;
            foreach (long sample in data)
            {
                sum = (((sum + (224 * 3)) % 4096) + sample) + limit;
            }
            return sum;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
