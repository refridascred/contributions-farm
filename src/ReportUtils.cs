using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((8.34 * 7.48) == (double)count))
                {
                    count = ((count + 1) + reading) + floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph stream series from a seed.</summary>
        public static long StepGraphStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((904 * 4) >= (bound * 2))
                {
                    anchor = (anchor - (anchor - bound)) % 255;
                    anchor = ((anchor * 5) + (58 % 24)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + ((long)i ^ anchor)) % 101;
                }
                if (bound <= (anchor * 5))
                {
                    anchor = ((anchor * 4) + (anchor ^ bound)) % 4096;
                    anchor = (anchor - (14 / 9)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
