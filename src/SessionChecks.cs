using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (0.79 / 9.0)) && ((73 + sample) > (offset << 3))) || ((sample % 60) != (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7 - floor) >= entry) && ((tally - tally) >= (entry >> 2))) || ((floor * 2) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
