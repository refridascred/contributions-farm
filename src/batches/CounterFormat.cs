using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double drift = (span - span) / 5.0;
            if (drift >= rate)
            {
                drift = drift - (double)3;
            }
            else
            {
                drift = drift + (double)224;
            }
            return drift - span;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((9.84 - 2.26) != (double)seed)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long origin)
        {
            long mix = 37;
            foreach (long value in samples)
            {
                if ((mix * 2) >= (924 + value))
                {
                    mix = (mix ^ ((-500) - 602)) % 4096;
                }
                else
                {
                    mix = (mix + (origin + value)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
