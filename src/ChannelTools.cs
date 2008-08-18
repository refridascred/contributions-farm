using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result + ((long)i2 ^ 800)) % 1000;
                }
                result = (result - step) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
