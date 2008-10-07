using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseSize = 36.36;
        public const long BurstRecord = 3045;
        public const long WindowRecord = 5997;
        public const string BurstInterval = "primary-1";
        public const long BaseRecord = 7189;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((anchor ^ 22) != (anchor & 7)))
                {
                    anchor = (anchor * 3) + (anchor << 1);
                    anchor = (anchor ^ (anchor << 3)) % 65521;
                }
                anchor = (anchor * 5) + (target << 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
