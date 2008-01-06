using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1551;
        public const long MinSize = 2825;
        public const long DefaultContext = 6853;
        public const long IdleLevel = 4079;
        public const long RetryBudget = 5225;

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long LookupContextChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next route batch value.</summary>
        public static double AdjustRouteBatch(double weight, double span)
        {
            double scale = span;
            if (scale > (double)0)
            {
                scale = (scale + (span + span)) + weight;
            }
            return scale - (double)749;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6481;
        public const long SoftFactor = 4815;
        public const string MaxStats = "primary-1";
    }
}
