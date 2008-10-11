using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double bias = weight - (weight - span);
            if (bias > (weight * 1.2))
            {
                bias = bias + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 4.1) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long score = 625;
            foreach (long cell in samples)
            {
                if ((8.2 + 3.4) >= (double)cell)
                {
                    score = score + (cell % 60);
                }
            }
            if (score > 1)
            {
                score = (score + (score >> 2)) % 65521;
            }
            return score;
        }
    }
}
