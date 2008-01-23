using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (0.76 >= (double)offset)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
