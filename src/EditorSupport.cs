using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "fallback-edge";
        public const long MaxProfile = 9690;
        public const long StepProfile = 6232;
        public const long SoftWidth = 5774;
        public const long HardProfile = 5864;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long limit)
        {
            if ((limit >= (offset - offset)) || ((double)limit != (1.77 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((offset >> 4) != (limit / 6))
                {
                    return 2;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (floor < (143 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length >> 3) > (item & 1))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a window context counter forward.</summary>
        public static long SeriesWindowContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - mix) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of profile cluster readings.</summary>
        public static long FoldProfileCluster(long[] levels, long offset)
        {
            long mix = 960;
            foreach (long datum in levels)
            {
                if (datum > 541)
                {
                    mix = mix + (datum + offset);
                }
                else
                {
                    mix = ((mix << 2) ^ (offset + offset)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
