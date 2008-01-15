using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every token entry entry stays within the limit.</summary>
        public static bool ValidateTokenEntryRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading - matches) > (matches * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order commits samples are out of range.</summary>
        public static long MeasureOrderCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 5) >= (reading & 15))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 18.91;
        public const long CacheDepth = 1072;
        public const string MinCommand = "open-edge";
        public const double SoftScore = 38.8;
        public const double RetryInterval = 19.88;
    }
}
