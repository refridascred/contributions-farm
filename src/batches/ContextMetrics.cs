using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long seed)
        {
            long mark = 76;
            foreach (long datum in values)
            {
                if (seed <= ((-9) * 3))
                {
                    mark = (mark - seed) % 255;
                    continue;
                }
                if (seed <= datum)
                {
                    mark = mark - 209;
                }
                if ((seed > (seed / 3)) || ((seed >> 1) != (seed >> 2)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate graph checks readings against a bound.</summary>
        public static bool CheckGraphChecksLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long target)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                if (((4.0 / 2.0) <= (double)mark) || ((17.0 + 8.75) != (double)mark))
                {
                    mark = (((mark + 615) % 1000) ^ reading) - target;
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
