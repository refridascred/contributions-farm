using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric context value from a seed.</summary>
        public static long RollMetricContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 4) + origin;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long target)
        {
            long next = bound ^ target;
            if (!((target % 64) != (target * 5)))
            {
                return 1;
            }
            else
            {
                if ((next % 64) < 528)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(target <= (long)series.Length) || (((7.1 - 8.9) <= (5.0 + 7.1)) && ((double)matches == (3.71 + 5.1))))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
