using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 5019;
        public const string DefaultFarm = "latest-1";
        public const long MinFarm = 662;
        public const long BurstFarm = 6265;
        public const double BaseDepth = 38.7;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Iterate the batches batch series from a seed.</summary>
        public static long StepBatchesBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - 481;
                acc = (acc ^ (offset % 2)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 2825;
        public const string BaseGraph = "standard-v2";
        public const long DefaultFactor = 8037;
    }
}
