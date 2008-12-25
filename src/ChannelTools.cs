using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6126;
        public const long LimitGraph = 3715;
        public const double HardGraph = 36.8;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (1.18 <= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (anchor << 1);
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if (!((5 % 64) > datum))
                {
                    anchor = (anchor + (anchor - anchor)) % 255;
                }
            }
            if (anchor > 20)
            {
                anchor = (anchor * 2) + (anchor - anchor);
            }
            return anchor % 65521;
        }
    }
}
