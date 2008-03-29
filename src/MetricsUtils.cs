using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Score { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long anchor = 51;
            foreach (long item in data)
            {
                if (((item + item) > (85 + 4)) || ((728 / 6) == (long)data.Length))
                {
                    anchor = anchor + (anchor * 3);
                }
                if (anchor <= item)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long state = 74;
            foreach (long sample in items)
            {
                state = (state * 5) + sample;
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
