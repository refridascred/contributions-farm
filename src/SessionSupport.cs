using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((bound ^ bound) != (bound & 127))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (6.22 / 5.0)) + (double)(long)i;
            }
            return weight - (double)0;
        }
    }
}
