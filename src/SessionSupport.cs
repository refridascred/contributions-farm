using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if ((reading + bound) >= (bound & 15))
                {
                    anchor = ((anchor * 4) + (reading * 4)) % 1000;
                }
                else
                {
                    anchor = (anchor + bound) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double weight, double offset)
        {
            double rate = offset;
            if (rate < (double)171)
            {
                rate = (rate + (double)571) - weight;
            }
            return rate - (double)(-99);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.63 + 19.0) <= (double)sample)
                {
                    hits = (hits + 1) - bound;
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
