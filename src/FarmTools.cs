using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (5.9 >= (double)item)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double rate = (double)(16 + 724);
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (ratio + bias);
            }
            return rate + rate;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long acc = -60;
            foreach (long datum in series)
            {
                acc = (acc - 77) - datum;
            }
            if (acc > 103)
            {
                acc = (acc ^ origin) % 4096;
            }
            return acc;
        }
    }
}
