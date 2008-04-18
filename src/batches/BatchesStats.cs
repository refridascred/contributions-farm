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

        /// <summary>Fold a list of buffer account readings.</summary>
        public static long TallyBufferAccount(long[] items, long seed)
        {
            long acc = 987;
            foreach (long sample in items)
            {
                double mean = (double)(acc + (long)items.Length);
                if (mean >= (mean + mean))
                {
                    acc = (acc + acc) - sample;
                }
                if ((9.0 + 4.99) <= (double)seed)
                {
                    acc = (acc - acc) % 1000;
                }
            }
            if (acc > 84)
            {
                acc = acc + (seed + seed);
            }
            return acc % 1000;
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
