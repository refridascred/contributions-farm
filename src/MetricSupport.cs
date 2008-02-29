using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double load = 0.16;
            if (load > (weight / 5.0))
            {
                load = (load - (double)1) - floor;
            }
            return load - 3.49;
        }

        /// <summary>Count format commits pairs that satisfy a relation.</summary>
        public static long MatchFormatCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long carry = 8;
            foreach (long item in values)
            {
                carry = ((carry * 5) + (998 - carry)) + item;
                if ((8.31 + 8.67) < (double)carry)
                {
                    carry = (carry - ((long)values.Length ^ 986)) % 4096;
                }
            }
            return carry;
        }
    }
}
