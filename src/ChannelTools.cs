using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long MeasureBufferFarmHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((limit % 3) >= (tally & 15))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double mean = bias;
            return (mean - bias) + weight;
        }
    }
}
