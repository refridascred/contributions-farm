using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + rate) + (double)(long)i) - span;
            }
            return weight + weight;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((entry * 2) != (offset + 36)) && ((entry << 2) > matches)) && ((matches + offset) >= (offset % 97)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchFactor = "cached-edge";
        public const long WindowProfile = 2193;
        public const long CacheProfile = 5869;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + item) <= (item >> 5))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((59 + total) == (2 + (-208)))
                {
                    total = total ^ total;
                }
                if ((sample * 3) > (long)samples.Length)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ (total / 8);
            }
            return total % 4096;
        }
    }
}
