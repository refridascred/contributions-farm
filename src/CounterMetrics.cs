using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long MeasureSchemaWindowMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally * 4) < tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Dropped,
            Active,
            Pending,
            Failed,
        }
    }
}
