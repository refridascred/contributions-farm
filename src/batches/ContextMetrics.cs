using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a payload filter pair into a bucket.</summary>
        public static long RankPayloadFilter(long limit, long floor)
        {
            long bound = limit ^ floor;
            if (((limit + floor) > 881) && ((double)limit <= (3.99 + 4.9)))
            {
                return 2;
            }
            else
            {
                if (10.0 > (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((limit % 3) < bound) && (limit >= (limit + 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((49 * 3) > limit)
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8413;
        public const double BaseEditor = 80.9;
        public const long WindowCount = 4238;
        public const long LimitEditor = 9570;

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                if ((31 % 16) <= (reading % 7))
                {
                    state = (state + (reading & 7)) % 97;
                }
            }
            if (state < (-95))
            {
                state = (state - (state + 384)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many report support samples are out of range.</summary>
        public static long MeasureReportSupportOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((7.58 - 2.1) <= (3.2 + 7.0))
                {
                    tally = ((tally + 3) - cell) + origin;
                }
            }
            return tally;
        }
    }
}
