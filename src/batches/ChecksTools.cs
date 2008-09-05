using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long seed)
        {
            long delta = bound ^ seed;
            if ((20.0 / 4.0) >= (double)delta)
            {
                return 5;
            }
            else
            {
                if (seed >= (delta - delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta * 2) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((-897) <= delta)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + (-520)) <= ((-670) - count)) || ((value + count) < (968 - 57)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long origin)
        {
            long mix = 736;
            foreach (long datum in items)
            {
                mix = ((mix - (datum & 7)) % 65521) + origin;
                mix = mix ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
