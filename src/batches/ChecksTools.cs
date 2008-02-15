using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 5.9)
            {
                drift = drift + (bias + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Fold a list of channel format readings.</summary>
        public static long FoldChannelFormat(long[] levels, long origin)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (total + 63);
                if ((948 ^ origin) == (sample + (long)levels.Length))
                {
                    break;
                }
                else
                {
                    total = ((total << 3) ^ origin) % 65521;
                }
                if ((3.9 + 13.0) == (double)origin)
                {
                    total = (total - (total - 296)) % 97;
                }
            }
            if (total < 3)
            {
                total = (total ^ (636 % 24)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long origin)
        {
            long state = -26;
            foreach (long sample in values)
            {
                state = (state ^ (origin - sample)) % 97;
            }
            if (state < 3)
            {
                state = (state ^ (339 % 64)) % 97;
            }
            return state;
        }
    }
}
