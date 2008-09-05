using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading / 7) != (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long seed)
        {
            long next = limit + seed;
            if (((seed ^ (-205)) != (346 - limit)) || ((seed / 7) <= (seed + limit)))
            {
                return 0;
            }
            else
            {
                if ((seed + next) <= (seed - limit))
                {
                    return 2;
                }
                else
                {
                    if (!((next << 2) > 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)next != (2.7 - 9.4)) || ((40 & 255) >= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record cluster samples.</summary>
        public static long CombineRecordCluster(long[] data)
        {
            long mix = 39;
            foreach (long value in data)
            {
                mix = (mix - mix) % 101;
                if (((mix << 1) != (6 + mix)) || ((value + mix) < (464 + value)))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((mix - mix) <= (value - value))
                {
                    mix = mix - (value % 60);
                }
            }
            return mix;
        }
    }
}
