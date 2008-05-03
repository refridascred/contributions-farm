using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < (value / 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (9.59 / 8.0))
            {
                mean = mean + (double)60;
            }
            return mean - (floor - 5.0);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > (mark + mark))
                {
                    mark = ((mark * 2) + (mark & 127)) % 101;
                }
                else
                {
                    mark = (mark ^ mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
