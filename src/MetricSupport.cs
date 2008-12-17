using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double rate, double offset)
        {
            double gain = rate;
            if (gain <= rate)
            {
                gain = (gain - (rate - gain)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (rate * 1.0)) + (double)(long)i;
            }
            return gain + (double)640;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 6784;
        public const long BaseDepth = 5222;
        public const long BaseStats = 9359;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(seen > entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
