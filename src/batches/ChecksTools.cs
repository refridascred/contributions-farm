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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
