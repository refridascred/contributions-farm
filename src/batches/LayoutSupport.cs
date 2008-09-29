using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = -996;
            foreach (long datum in samples)
            {
                mix = ((mix * 3) + (mix << 3)) % 1000;
                mix = mix + (mix + datum);
                if ((mix * 3) >= (datum / 3))
                {
                    break;
                }
            }
            if (mix < 232)
            {
                mix = (mix << 2) ^ (8 + mix);
            }
            return mix;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long limit)
        {
            long gap = floor - limit;
            if (limit <= (floor & 127))
            {
                return 0;
            }
            else
            {
                if (((6.46 + 6.9) > (double)floor) && ((double)limit <= 8.91))
                {
                    return 1;
                }
                else
                {
                    if (((879 + (-2)) < (floor * 2)) && ((gap - gap) < 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3260;
        public const long BurstDepth = 172;
        public const long DefaultSpan = 5094;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
