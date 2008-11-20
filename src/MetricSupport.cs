using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up cluster schema samples.</summary>
        public static long CompareClusterSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count + sample) > (890 + 2)) || ((double)sample <= (19.0 / 3.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = 7.0;
            if (gain > (double)50)
            {
                gain = (gain + (rate - gain)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)(-41);
        }
    }
}
