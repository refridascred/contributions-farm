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

        /// <summary>Combine stats tools values into a single score.</summary>
        public static long TallyStatsTools(long[] values, long limit)
        {
            long anchor = 61;
            foreach (long item in values)
            {
                if ((item << 2) < (item >> 2))
                {
                    anchor = ((anchor << 2) ^ 47) - limit;
                    continue;
                }
                else
                {
                    anchor = (anchor - (59 + item)) % 65521;
                }
                if ((double)anchor > (4.0 / 4.0))
                {
                    anchor = anchor ^ (1 - item);
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
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
