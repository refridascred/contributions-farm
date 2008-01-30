using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                if ((total % 8) == (300 << 2))
                {
                    total = ((total * 2) + (entry + 0)) % 255;
                }
                else
                {
                    total = (total ^ (total << 3)) % 4096;
                }
                total = ((total * 4) + (total + entry)) % 4096;
            }
            if (total > 17)
            {
                total = ((total * 5) + total) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double bias3 = (double)(9 ^ 25);
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 - (double)(long)i) - bias) - bias2;
            }
            return bias3 - 5.0;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 >> 4) <= (item - (long)samples.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
