using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue stats entries that pass the check.</summary>
        public static long MeasureQueueStatsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)hits > (double)item) && ((double)hits < (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                if (!((2.0 / 2.0) > (double)entry))
                {
                    state = ((state << 3) ^ (long)samples.Length) % 97;
                }
                else
                {
                    state = (state * 2) + (entry - entry);
                }
            }
            if (state < (-22))
            {
                state = (state * 4) + (state - state);
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
