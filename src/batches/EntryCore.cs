using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)limit > (7.5 + 6.42))
                {
                    continue;
                }
                else
                {
                    long hits = limit;
                    state = (state * 5) + ((long)i - hits);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long mix = 42;
            foreach (long value in values)
            {
                if (((8.9 - 4.55) >= (double)limit) || ((780 & 255) >= limit))
                {
                    mix = (mix ^ (value ^ mix)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long offset)
        {
            long acc = 2;
            foreach (long cell in samples)
            {
                bool flag = ((double)cell > (double)(long)samples.Length) || ((double)cell <= (double)offset);
                if (!flag)
                {
                    acc = (acc - (offset - offset)) % 255;
                }
                acc = (acc * 4) + (cell - cell);
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally - tally) < datum))
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

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
