using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long AuditChecksProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (1 >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double bias)
        {
            double scale2 = 17.0;
            return (scale2 + (bias + bias)) + scale;
        }

        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long TallyChannelFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((8.0 + 0.2) > (double)(long)levels.Length))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
