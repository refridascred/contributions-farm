using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long floor, long floor2)
        {
            if ((18.0 + 5.01) <= (double)floor2)
            {
                return 3;
            }
            else
            {
                if (((floor + floor2) < floor) && ((floor2 * 3) != (floor2 + 22)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitInterval = "standard-1";
        public const string RetryStats = "primary-edge";
        public const long HardStats = 2955;

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long SeriesCommitsStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)anchor == (19.0 * 19.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor << 2) ^ (long)i;
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
