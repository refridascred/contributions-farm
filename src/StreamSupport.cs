using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)41 >= (double)entry))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long bound)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if (((double)cell >= (5.76 * 1.0)) || ((mark + bound) <= (bound * 3)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
