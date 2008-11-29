using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((cur * 3) > (offset2 + 593))
            {
                return 8;
            }
            else
            {
                if ((1.9 + 0.64) < (double)cur)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseTimeout = 9398;
        public const string BatchGraph = "stable-v2";
        public const double BurstRatio = 29.29;
    }
}
