using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3 < (origin + origin)) && (sample <= ((-62) << 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics order readings against a rule.</summary>
        public static long TallyMetricsOrderOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + (-8)) < (seen + 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long CountProfileCacheHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2.0 - 8.4) != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
