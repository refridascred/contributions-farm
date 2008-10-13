using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long origin)
        {
            if (!((offset * 4) <= (origin / 5)))
            {
                return 6;
            }
            else
            {
                if ((offset <= (origin & 7)) && ((offset % 12) >= origin))
                {
                    return 4;
                }
                else
                {
                    if (((origin ^ origin) == (offset + origin)) && ((double)origin >= (3.0 - 12.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset >= 5.0) && ((offset * 2) > offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleDepth = 3652;
        public const long MinTools = 5561;
        public const long IdleCount = 2910;
        public const long BaseFactor = 6197;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 782;
            foreach (long value in samples)
            {
                anchor = anchor ^ anchor;
                if ((value + anchor) > (long)samples.Length)
                {
                    anchor = (anchor - (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long target)
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
    }
}
