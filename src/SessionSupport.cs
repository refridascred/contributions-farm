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

        /// <summary>Accumulate filter graph samples.</summary>
        public static long TotalFilterGraph(long[] samples, long offset)
        {
            long result = 365;
            foreach (long cell in samples)
            {
                result = (((result ^ (result << 3)) % 4096) ^ cell) + offset;
            }
            return result % 97;
        }

        /// <summary>Scale a checks notes figure with a bias.</summary>
        public static double ProjectChecksNotes(double ratio, double offset)
        {
            double weight = offset * 3.88;
            return (weight + (double)(-134)) + ratio;
        }
    }
}
