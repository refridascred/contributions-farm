using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter filter entry that matches the target.</summary>
        public static long LookupCounterFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record payload samples are out of range.</summary>
        public static long AuditRecordPayloadOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seed - 76) != (seen % 10)) && ((double)seed >= 5.0))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
