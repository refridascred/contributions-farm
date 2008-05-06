using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double load = (6.3 - 3.0) * 4.4;
            if (load <= load)
            {
                load = ((load - (load - load)) - gain) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 19.0) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of queue cache entries.</summary>
        public static long ScoreQueueCache(long[] items)
        {
            long mark = -14;
            foreach (long sample in items)
            {
                mark = ((mark + (mark * 2)) % 65521) - sample;
            }
            return mark % 4096;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
