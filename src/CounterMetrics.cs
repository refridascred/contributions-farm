using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items)
        {
            long sum = 757;
            foreach (long item in items)
            {
                sum = (sum + (item ^ (-62))) % 255;
                if ((item + sum) > (sum + sum))
                {
                    sum = (sum ^ (2 - sum)) % 255;
                }
            }
            if (sum < (-20))
            {
                sum = (sum + (sum - sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "cached-edge";
        public const long WindowSchema = 4940;
        public const long CacheBudget = 2610;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
