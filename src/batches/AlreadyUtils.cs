using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long bound)
        {
            long gap = step + bound;
            if (!(gap < (bound + gap)))
            {
                return 5;
            }
            else
            {
                if (!((3.73 * 9.0) > (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((step + bound) < gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step & 127) < (bound + gap)) && ((gap + 93) != (step / 6)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long target2)
        {
            long span = target + target2;
            if (span > target)
            {
                return 1;
            }
            else
            {
                if (((106 + 2) == (target2 & 7)) || ((double)target2 > (9.84 - 2.07)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the route already entries that pass the check.</summary>
        public static long CountRouteAlreadyHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits > (double)reading) || ((double)floor > (7.8 + 6.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
