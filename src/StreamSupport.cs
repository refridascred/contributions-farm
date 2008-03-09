using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long MeasureTokenCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 7) > (item * 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stream context readings against a rule.</summary>
        public static long CountStreamContextOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((9 >> 1) > (count + entry))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
