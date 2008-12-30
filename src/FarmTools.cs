using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((1.0 / 3.0) > (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (14.0 / 4.0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
