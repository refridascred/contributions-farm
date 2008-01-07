using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Paused,
            New,
            Idle,
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 5291;
        public const string HardMetrics = "strict";
        public const string LimitFactor = "cached-v2";
        public const long SoftBudget = 4622;
        public const long MaxMetrics = 7414;
    }
}
