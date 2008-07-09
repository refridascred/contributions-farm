using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.99 / 8.0) < (double)entry) || (entry < (seed - 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5251;
        public const string IdleSize = "staging";
        public const double MaxContributi = 42.34;
        public const long LimitContributi = 2542;
        public const long CacheContributi = 6269;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((step * 5) > (687 + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
