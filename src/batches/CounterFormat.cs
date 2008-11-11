using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length ^ reading) >= (offset - offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long anchor = 172;
            foreach (long entry in samples)
            {
                anchor = anchor - anchor;
                if ((entry + entry) < (anchor >> 3))
                {
                    anchor = (anchor ^ (445 + entry)) % 4096;
                }
                if ((anchor & 7) > entry)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
