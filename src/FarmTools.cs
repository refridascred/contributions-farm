using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double ratio = gain;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias + ratio)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((offset - reading) > (13 << 2)) && ((reading - reading) <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels, long origin)
        {
            long anchor = -220;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample >> 3)) % 101;
                if ((sample + origin) >= (origin % 10))
                {
                    anchor = (anchor ^ (630 + origin)) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
