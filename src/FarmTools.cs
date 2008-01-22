using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data)
        {
            long mix = 519;
            foreach (long value in data)
            {
                if (!((double)mix <= (double)618))
                {
                    mix = ((mix * 5) + (mix % 10)) % 1000;
                }
                if ((value / 5) == (2 << 3))
                {
                    mix = (mix * 4) + (38 + 548);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - floor) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
