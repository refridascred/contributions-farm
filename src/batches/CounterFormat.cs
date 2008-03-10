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

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long floor)
        {
            long edge = target + floor;
            if ((target >> 1) < (target ^ target))
            {
                return 1;
            }
            else
            {
                if ((floor + 213) <= (target >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((edge - target) < (floor << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
