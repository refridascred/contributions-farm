using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples)
        {
            long anchor = 0;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 101;
                if ((anchor + 6) > (reading & 1))
                {
                    anchor = ((anchor * 4) + ((long)samples.Length + reading)) % 1000;
                }
            }
            return anchor;
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
