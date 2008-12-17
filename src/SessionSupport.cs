using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 4; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (bias * 2.0);
        }

        /// <summary>Measure how many commits order samples are out of range.</summary>
        public static long CountCommitsOrderHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((7 >> 2) == (count % 97)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a checks notes figure with a bias.</summary>
        public static double ProjectChecksNotes(double ratio, double offset)
        {
            double weight = offset * 3.88;
            return (weight + (double)(-134)) + ratio;
        }
    }
}
