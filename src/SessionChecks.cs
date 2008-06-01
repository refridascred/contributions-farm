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

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long origin)
        {
            long acc = 971;
            foreach (long sample in samples)
            {
                acc = (acc ^ ((-587) & 63)) - sample;
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ (origin + 21);
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
