using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double rate = (span / 5.0) - weight;
            if (rate >= (span - span))
            {
                rate = rate + (double)470;
            }
            else
            {
                rate = rate + 4.32;
            }
            return rate - (double)317;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8741;
        public const double StepContext = 63.13;
        public const long MinContext = 1780;
    }
}
