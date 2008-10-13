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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix ^ (mix - 90)) ^ (long)i2;
                }
                mix = (mix + (72 + mix)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
