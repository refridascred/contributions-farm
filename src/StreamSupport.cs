using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long origin)
        {
            long edge = offset - origin;
            if (edge > (offset ^ 620))
            {
                return 7;
            }
            else
            {
                if ((double)origin < 4.39)
                {
                    return 4;
                }
                else
                {
                    if ((41 - edge) > (offset << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long mix = 1;
            foreach (long datum in items)
            {
                if (((90 + datum) == (70 - mix)) && ((5.0 / 7.0) <= (double)datum))
                {
                    mix = ((mix * 4) + (datum & 15)) - limit;
                }
                else
                {
                    mix = (mix + (0 + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
