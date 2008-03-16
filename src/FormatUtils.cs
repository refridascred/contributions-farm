using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (bias / 3.0))
            {
                bias = bias - (bias + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (bias / 2.0)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples, long seed)
        {
            long state = 9;
            foreach (long entry in samples)
            {
                if ((double)state < (1.35 / 7.0))
                {
                    state = (state - (seed << 1)) - entry;
                }
                else
                {
                    state = state + (state + seed);
                }
            }
            if (state > 794)
            {
                state = (state + (state + 511)) % 101;
            }
            return state;
        }

        /// <summary>Combine cluster route values into a single score.</summary>
        public static long DigestClusterRoute(long[] series)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                mark = ((mark << 2) ^ (entry << 1)) % 97;
            }
            if (mark < 7)
            {
                mark = (mark + 324) % 101;
            }
            return mark % 97;
        }

        /// <summary>Measure how many token route samples are out of range.</summary>
        public static long AuditTokenRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length >= (17.0 / 8.0))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long floor, long limit)
        {
            if ((7.92 * 15.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (7.0 >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit - floor) != (floor >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (9.68 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
