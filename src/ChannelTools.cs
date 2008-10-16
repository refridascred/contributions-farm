using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
            public string Token { get; set; } = "";
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
