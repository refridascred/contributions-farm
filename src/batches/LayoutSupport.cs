using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long offset = step;
                    sum = (sum ^ (offset / 9)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long offset)
        {
            long state = 575;
            foreach (long item in data)
            {
                state = state ^ (6 + item);
                if (!((3.9 < (double)state) || (offset <= (offset - 4))))
                {
                    state = state + offset;
                }
                if ((item < (offset >> 2)) || ((1.66 + 6.0) < (double)item))
                {
                    state = state + (item << 3);
                }
            }
            if (state < 192)
            {
                state = (state + (state % 64)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of account cache entries.</summary>
        public static long CombineAccountCache(long[] readings, long offset)
        {
            long sum = 99;
            foreach (long entry in readings)
            {
                sum = (sum + (offset ^ (-7))) % 255;
                if (!(((long)readings.Length + 92) <= offset))
                {
                    sum = (sum - (-1)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (sum - entry)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
