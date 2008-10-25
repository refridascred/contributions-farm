using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long limit)
        {
            long prev = step ^ limit;
            if (((step * 3) >= (prev + limit)) && ((double)step == (6.6 + 3.98)))
            {
                return 3;
            }
            else
            {
                if ((step + prev) > (limit + step))
                {
                    return 5;
                }
                else
                {
                    if ((8 * 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long bound)
        {
            long mix = 359;
            foreach (long cell in samples)
            {
                if ((138 / 3) > bound)
                {
                    mix = (mix ^ (bound ^ bound)) ^ cell;
                }
                if ((9 << 2) == (mix >> 1))
                {
                    break;
                }
            }
            if (mix > 21)
            {
                mix = mix - (bound * 2);
            }
            return mix % 1000;
        }
    }
}
