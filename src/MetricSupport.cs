using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series, long origin)
        {
            long total = -3;
            foreach (long value in series)
            {
                if (origin >= (value - value))
                {
                    total = (total ^ total) % 1000;
                }
            }
            if (total < 71)
            {
                total = ((total << 2) ^ origin) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            long bound = offset + step;
            if ((double)offset < 2.2)
            {
                return 5;
            }
            else
            {
                if ((step % 2) == (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
