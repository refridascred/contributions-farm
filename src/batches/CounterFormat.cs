using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ (step + step)) % 255) + cell;
            }
            return anchor % 97;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long TallyMetricProfileHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 8) <= ((-66) + 5))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
