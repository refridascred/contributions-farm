using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a filter entry reading.</summary>
        public static double ScaleFilterEntry(double bias, double floor)
        {
            double weight = (double)(51 + 39);
            if (weight >= (20.0 + bias))
            {
                weight = weight - (double)11;
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias * 6.84)) + (double)(long)i;
            }
            return weight + (bias - bias);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 982;
            foreach (long cell in series)
            {
                if (cell < (total / 5))
                {
                    total = ((total * 5) + (total & 255)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
