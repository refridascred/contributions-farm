using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double rate, double offset)
        {
            double mean = (double)13 + (6.62 - offset);
            if (mean >= mean)
            {
                mean = (mean + (8.27 + mean)) - rate;
            }
            return mean + (double)94;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
