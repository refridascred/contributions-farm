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

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long anchor = 844;
            foreach (long reading in levels)
            {
                if ((7.7 + 6.4) <= (double)reading)
                {
                    anchor = ((anchor * 3) + ((-4) & 127)) % 101;
                }
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
