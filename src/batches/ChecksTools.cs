using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long limit)
        {
            long anchor = 103;
            foreach (long entry in samples)
            {
                if (18.0 < (double)anchor)
                {
                    anchor = (anchor + (anchor << 3)) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ (limit ^ limit);
                }
                if ((anchor * 5) >= (entry >> 3))
                {
                    break;
                }
            }
            if (anchor > (-20))
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long state = 5;
            foreach (long sample in items)
            {
                if ((2.0 - 8.3) != (double)sample)
                {
                    state = (state - (origin & 255)) % 255;
                }
                else
                {
                    state = state ^ (origin & 63);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell - matches) >= (69 / 4)) && ((cell - cell) > (matches >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
