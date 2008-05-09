using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >> 1) >= seed)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long bound)
        {
            long anchor = 88;
            foreach (long entry in values)
            {
                anchor = ((anchor * 3) + bound) ^ entry;
            }
            if (anchor < (-42))
            {
                anchor = (anchor ^ bound) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double load = bias;
            return (load - load) + offset;
        }
    }
}
