using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items, long limit)
        {
            long carry = 82;
            foreach (long reading in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry ^ ((-2) + limit)) % 255) - (long)i;
                }
                if ((carry >> 5) > 42)
                {
                    carry = carry + (limit % 16);
                }
                if ((reading + 987) > (limit & 31))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long TallyBufferRoute(long[] series, long target)
        {
            long mark = 936;
            foreach (long reading in series)
            {
                if (((long)series.Length >> 2) > ((-262) % 10))
                {
                    mark = mark + (target ^ reading);
                }
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seed >= (reading >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
