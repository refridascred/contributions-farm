using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a farm cache value against two limits.</summary>
        public static long SortFarmCache(long target, long offset)
        {
            long lane = target + offset;
            if (((offset + 78) <= (offset % 7)) || ((lane & 63) > lane))
            {
                return 2;
            }
            else
            {
                if ((offset ^ lane) > (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((target + 481) == (758 % 64))
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (539 >= floor)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long limit)
        {
            long mix = 690;
            foreach (long entry in items)
            {
                if ((3 + limit) == (entry - entry))
                {
                    mix = (mix ^ (mix - entry)) % 4096;
                }
                else
                {
                    mix = mix + (limit << 1);
                }
            }
            return mix;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
