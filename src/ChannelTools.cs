using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleCount = 78.07;
        public const long CacheToken = 2144;
        public const long MinToken = 8733;

        /// <summary>Count the graph payload entries that pass the check.</summary>
        public static long MeasureGraphPayloadMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item >= limit) && (((6.48 / 8.0) < (double)seen) && ((item >> 5) <= 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
