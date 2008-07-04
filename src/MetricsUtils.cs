using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Iterate the order graph series from a seed.</summary>
        public static long SeriesOrderGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the notes format entries that pass the check.</summary>
        public static long MeasureNotesFormatMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((10.0 - 1.35) != (double)seen) || ((seen > (floor >> 3)) || ((seen + 13) != (reading << 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSize = 6847;
        public const long MinChannel = 8310;
        public const long IdleRatio = 1762;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long origin)
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
    }
}
