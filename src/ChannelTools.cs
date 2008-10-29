using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((limit ^ 35) <= (reading + reading))
                {
                    score = ((score << 3) ^ (-7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((4.86 + 4.7) > (double)limit)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
