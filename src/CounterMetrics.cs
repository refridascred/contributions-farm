using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a profile format counter forward.</summary>
        public static long DeriveProfileFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - ((-6) & 15)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double rate = offset;
            if (rate <= gain)
            {
                rate = rate - offset;
            }
            return rate - rate;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long target)
        {
            long result = 767;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)result)
                {
                    result = ((result - item) % 4096) - target;
                }
                else
                {
                    result = (result ^ (result % 60)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits * 4) < (floor ^ floor))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
