using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two support tools measurements.</summary>
        public static double ScaleSupportTools(double scale, double bias)
        {
            double load = (double)(70 >> 2);
            if (load >= 11.0)
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load + (scale + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 5.7) - (double)(long)i;
            }
            return load - (double)(-596);
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double weight = span;
            if (weight < rate)
            {
                weight = weight + (weight * 7.0);
            }
            else
            {
                weight = weight - (double)203;
            }
            return weight - (span + 17.0);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((74 / 3) < (count + count)) && ((count ^ cell) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
