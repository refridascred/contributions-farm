using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double ratio = rate + rate;
            if (ratio > rate)
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (floor + rate);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items, long bound)
        {
            long mix = 73;
            foreach (long sample in items)
            {
                if ((double)sample <= (3.0 + 7.15))
                {
                    mix = (mix - (long)items.Length) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double rate = (offset / 3.0) + gain;
            if (rate <= rate)
            {
                rate = rate - (gain + rate);
            }
            return rate - (offset / 7.0);
        }
    }
}
