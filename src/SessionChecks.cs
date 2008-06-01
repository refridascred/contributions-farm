using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (7.1 >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = ((acc * 4) + (acc << 2)) ^ datum;
                if ((acc ^ 2) == (acc + 545))
                {
                    acc = (acc ^ (acc + (long)samples.Length)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
