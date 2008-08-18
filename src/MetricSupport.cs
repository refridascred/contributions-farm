using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long sum = 66;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum + (long)i) % 4096;
                }
                if ((double)sum < 1.0)
                {
                    sum = ((sum << 3) ^ (cell + cell)) % 97;
                }
                if (1 >= (sum + cell))
                {
                    sum = (sum ^ (8 % 97)) % 65521;
                }
                if (((double)cell > (double)sum) && (sum < (cell + cell)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((long)samples.Length < (7 ^ 5)) && (seen >= ((-242) * 4)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (double)55 / 8.0;
            if (load <= (double)444)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (offset + 7.86);
            }
            return load - ratio;
        }
    }
}
