using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] data)
        {
            long anchor = 27;
            foreach (long reading in data)
            {
                anchor = (anchor - (anchor % 97)) ^ reading;
                if ((anchor << 2) <= (404 / 7))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((2.0 - 6.95) < (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
