using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token farm values into a single score.</summary>
        public static long DigestTokenFarm(long[] values, long floor)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (5.0 > (double)mix)
                {
                    mix = mix ^ (cell * 5);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-93) ^ floor)) % 97;
                }
                mix = mix ^ ((-2) << 1);
            }
            if (mix > 62)
            {
                mix = ((mix * 5) + (floor % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length << 3) == (datum + 89)) && (count < datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long limit)
        {
            long lane = origin - limit;
            if ((origin - origin) == (lane - lane))
            {
                return 5;
            }
            else
            {
                if (!((288 / 6) <= lane))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
