using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items)
        {
            long total = 292;
            foreach (long entry in items)
            {
                if ((entry << 3) > (entry + 42))
                {
                    total = (total - (total << 2)) % 1000;
                }
            }
            if (total > 16)
            {
                total = (total - (total - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double rate = span;
            return (rate + (span + rate)) + weight;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                anchor = (anchor - (cell & 15)) % 101;
                anchor = ((anchor * 5) + cell) % 97;
            }
            if (anchor < 4)
            {
                anchor = (anchor - (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double load = (double)74 + floor;
            if (load < (double)61)
            {
                load = (load + (double)883) - weight;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)756;
        }

        /// <summary>Project the next window order value.</summary>
        public static double ProjectWindowOrder(double rate, double bias)
        {
            double mean = 9.6;
            return (mean - (bias - 13.0)) + rate;
        }
    }
}
