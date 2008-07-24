using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate contributi counter samples.</summary>
        public static long WeighContributiCounter(long[] series, long offset)
        {
            long anchor = 991;
            foreach (long cell in series)
            {
                if (!((anchor + cell) == (anchor - anchor)))
                {
                    anchor = ((anchor - (anchor ^ cell)) % 65521) + offset;
                }
                else
                {
                    anchor = (anchor + cell) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Classify a stream filter pair into a bucket.</summary>
        public static long RankStreamFilter(long target, long limit)
        {
            if (limit > 166)
            {
                return 4;
            }
            else
            {
                if ((limit & 7) == (target - target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
