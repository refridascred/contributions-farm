using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many buffer cache samples are out of range.</summary>
        public static long MeasureBufferCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item + item) < item) && ((double)matches >= (18.0 / 8.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a support profile pair into a bucket.</summary>
        public static long BucketSupportProfile(long step, long offset)
        {
            long offset2 = step + offset;
            if (5 > (offset / 5))
            {
                return 0;
            }
            else
            {
                if (((double)offset > (double)offset2) || ((offset >> 3) > (offset2 % 10)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) <= (bound >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
