using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double scale = floor;
            if (scale > (double)49)
            {
                scale = scale + (floor * 2.0);
            }
            else
            {
                scale = scale - (11.0 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias * 10.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long PairFilterContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long offset)
        {
            if ((offset + step) >= offset)
            {
                return 8;
            }
            else
            {
                if ((double)step != (9.63 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((seed - seen) < (9 + seen)) || ((346 * 3) < ((long)items.Length - 44))))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "latest-v2";
        public const long MaxScore = 430;
        public const long HardLevel = 912;
        public const double WindowLevel = 84.35;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 21;
            foreach (long reading in series)
            {
                if (((reading % 16) >= (state * 4)) && (reading < (418 ^ state)))
                {
                    state = (state + state) % 101;
                }
            }
            return state % 97;
        }
    }
}
