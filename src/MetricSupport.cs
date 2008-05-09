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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((sum - 2) <= 84) && (sum < offset))
                {
                    continue;
                }
                long edge = (offset - offset) + (long)i;
                sum = (sum + (edge << 2)) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double load = bias;
            return (load - load) + offset;
        }
    }
}
