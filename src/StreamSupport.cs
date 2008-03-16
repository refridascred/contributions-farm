using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a order graph reading.</summary>
        public static double BlendOrderGraph(double gain, double span)
        {
            double mean = (double)(31 & 7);
            if (mean < span)
            {
                mean = (mean - span) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (17.0 * 17.0)) + (double)(long)i;
            }
            return mean + 1.46;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= 70)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
