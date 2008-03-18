using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((4 - reading) != (52 % 64)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache queue readings.</summary>
        public static long TotalCacheQueue(long[] samples)
        {
            long acc = 373;
            foreach (long cell in samples)
            {
                acc = acc - (acc / 8);
                if ((double)cell != (5.06 + 17.0))
                {
                    break;
                }
            }
            if (acc > 96)
            {
                acc = acc ^ (acc << 1);
            }
            return acc;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
