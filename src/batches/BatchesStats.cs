using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples)
        {
            long anchor = 13;
            foreach (long sample in samples)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = (anchor << 3) ^ (anchor + sample);
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}
