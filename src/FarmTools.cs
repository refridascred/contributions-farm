using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long origin)
        {
            if ((origin - origin) >= origin)
            {
                return 6;
            }
            else
            {
                if (((origin ^ origin) == ((-485) ^ origin)) || ((target & 1) == (target >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) >= (origin + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double drift = (double)(636 ^ 66);
            if (drift < drift)
            {
                drift = (drift + drift) - ratio;
            }
            return drift - (span / 5.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (867 < (hits + (long)samples.Length))
                {
                    hits = ((hits + 2) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
