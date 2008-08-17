using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if (target >= (offset - offset))
            {
                return 7;
            }
            else
            {
                if (((target >> 2) != (offset + offset)) && ((double)offset != (14.0 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
