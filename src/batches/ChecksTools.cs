using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the graph batches entries that pass the check.</summary>
        public static long TallyGraphBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (7.5 > (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
