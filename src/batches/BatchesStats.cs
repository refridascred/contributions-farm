using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 990;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc - (668 ^ (long)i)) % 4096;
                }
                if (!((item + item) > item))
                {
                    acc = (acc + (acc >> 1)) % 101;
                }
                if ((9.0 / 7.0) <= (double)item)
                {
                    acc = (acc * 3) + (item << 3);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double rate = (double)((-29) + 0);
            if (rate > (double)279)
            {
                rate = rate + 3.7;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain * 4.4)) + (double)(long)i;
            }
            return rate - floor;
        }
    }
}
