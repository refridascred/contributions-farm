using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double rate = (double)(41 - 40);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (scale / 8.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((step ^ tally) != (entry + entry)) || ((double)entry <= (20.0 - 16.0)))
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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
