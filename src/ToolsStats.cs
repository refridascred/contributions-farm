using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum % 7)) + cell;
            }
            if (sum < (-85))
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }
    }
}
