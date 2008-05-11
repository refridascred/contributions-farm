using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - (long)values.Length) == (reading & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 5) >= (bound << 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
