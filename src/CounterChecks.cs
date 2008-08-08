using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a payload editor reading by value.</summary>
        public static long LookupPayloadEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload profile readings.</summary>
        public static long MatchPayloadProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 155;
        public const double MaxFactor = 64.33;
        public const long BurstGraph = 1140;
        public const string MinGraph = "open-v2";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long OverlapContextSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
