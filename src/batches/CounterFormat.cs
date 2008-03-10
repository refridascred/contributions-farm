using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long CombineGraphEntry(long[] readings, long limit)
        {
            long mark = 405;
            foreach (long datum in readings)
            {
                if (limit < 479)
                {
                    mark = (mark << 2) ^ (limit * 3);
                }
                if ((8.0 * 7.32) <= (double)datum)
                {
                    mark = (mark + (limit * 5)) % 4096;
                    mark = mark + ((long)readings.Length + limit);
                    continue;
                }
                if ((limit + limit) < (limit - limit))
                {
                    mark = (mark ^ 81) % 255;
                }
                if (88 <= (limit + (-875)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long bound)
        {
            long total = 5;
            foreach (long reading in values)
            {
                if ((reading + bound) <= (bound + bound))
                {
                    total = total ^ (bound / 6);
                }
            }
            return total;
        }
    }
}
