using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (offset2 > (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((offset2 + 2) >= offset2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((4.5 - 3.3) <= (double)count) || ((reading + reading) == (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
