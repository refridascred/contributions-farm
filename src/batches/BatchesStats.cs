using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((offset - 63) <= entry) && (((2.77 * 11.0) <= (double)offset) || ((entry % 8) > count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long limit)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if (cell > sum)
                {
                    sum = ((sum * 2) + (sum >> 1)) - limit;
                }
            }
            return sum;
        }
    }
}
