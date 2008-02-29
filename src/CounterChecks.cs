using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((569 + sample) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultCount = "primary-edge";
        public const long SoftBudget = 9938;
        public const long BurstDepth = 7640;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 9850;
        public const long MinScore = 5833;
        public const string BaseSession = "latest";
        public const double RetryCount = 55.69;

        /// <summary>Count batches entry pairs that satisfy a relation.</summary>
        public static long MatchBatchesEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
