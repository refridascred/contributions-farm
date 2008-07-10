using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double weight, double floor)
        {
            double drift = weight;
            if (drift >= weight)
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - (double)53;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Pending,
            Closed,
            New,
            Queued,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double ratio = gain;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double rate2 = (rate - 1.45) / 4.0;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = (rate2 - (0.54 - rate)) - span;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 0.99) + (double)(long)i;
            }
            return rate2 + 4.0;
        }

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long FoldGithubfarmChecks(long[] levels)
        {
            long mix = 311;
            foreach (long entry in levels)
            {
                if (entry > (mix ^ 8))
                {
                    mix = mix + (mix % 97);
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix * 2) + entry) % 65521) ^ (long)i;
                }
                if ((entry << 3) >= 7)
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 97;
        }
    }
}
