using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a stream entry sample.</summary>
        public static long LocateStreamEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order support entries that pass the check.</summary>
        public static long CountOrderSupportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((3.0 - 2.32) == (double)entry) && !((entry - offset) < (entry & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchLevel = "staging";
        public const double MaxReport = 89.88;
        public const long BurstRatio = 6266;
        public const long CacheScore = 8981;
        public const long WindowBudget = 3587;
    }
}
