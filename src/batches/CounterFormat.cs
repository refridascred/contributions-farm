using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + 4) != (datum + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
