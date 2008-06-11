using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count < (8.74 + 4.5))
                {
                    count = ((count + 3) - value) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Draft,
            Done,
        }
    }
}
