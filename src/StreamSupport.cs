using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long MeasureChannelFarmHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally >= (tally * 2)))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch context counter forward.</summary>
        public static long StepBatchContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc - ((long)i2 % 10)) % 4096;
                }
                if ((16.0 * 3.95) <= (double)limit)
                {
                    acc = ((acc << 3) ^ 389) % 255;
                    acc = (acc << 2) ^ (acc ^ (long)i);
                }
                else
                {
                    long next = 256 - (acc >> 4);
                    acc = ((acc << 2) ^ next) % 97;
                }
                if (!(((long)i - limit) != (96 + (long)i)))
                {
                    acc = ((acc << 2) ^ ((long)i >> 1)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Synced,
            New,
        }
    }
}
