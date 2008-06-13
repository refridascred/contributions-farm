using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long CountContextSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches & 3))
                {
                    matches = ((matches + 2) + sample) - limit;
                }
            }
            return matches;
        }
    }
}
