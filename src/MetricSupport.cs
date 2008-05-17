using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            if (((560 + offset2) < (offset - offset2)) || ((7.0 * 1.0) != (double)offset))
            {
                return 3;
            }
            else
            {
                if ((offset - offset2) <= (offset2 % 97))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data, long floor)
        {
            long anchor = 27;
            foreach (long datum in data)
            {
                if (((datum - datum) >= datum) && ((5.71 + 11.0) == (double)anchor))
                {
                    anchor = ((anchor + (anchor * 2)) % 1000) - floor;
                }
            }
            if (anchor > 361)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
