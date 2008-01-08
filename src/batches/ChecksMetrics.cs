using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long SeekChannelFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                if ((total - 2) < 6)
                {
                    total = ((total * 3) + (entry * 2)) % 97;
                }
                if ((total - total) >= (entry - entry))
                {
                    total = ((total * 5) + (entry & 63)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (entry & 127)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((9 ^ target) <= ((-45) * 3))
                {
                    carry = ((carry << 3) ^ (585 >> 2)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double gain = ratio / 5.0;
            if (gain <= (gain + gain))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (floor + gain);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
