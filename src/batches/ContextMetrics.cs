using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long offset2)
        {
            long span = offset - offset2;
            if ((span <= (94 % 8)) || ((offset * 5) > (535 % 60)))
            {
                return 6;
            }
            else
            {
                if ((span % 24) < (offset2 + offset2))
                {
                    return 0;
                }
                else
                {
                    if ((span / 6) > (span - span))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long seed)
        {
            long mark = 76;
            foreach (long datum in values)
            {
                if (seed <= ((-9) * 3))
                {
                    mark = (mark - seed) % 255;
                    continue;
                }
                if (seed <= datum)
                {
                    mark = mark - 209;
                }
                if ((seed > (seed / 3)) || ((seed >> 1) != (seed >> 2)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long target, long step)
        {
            if (((target + 985) != (step - target)) || ((double)target != (17.0 - 3.62)))
            {
                return 3;
            }
            else
            {
                if (((double)target >= (5.6 - 5.3)) && (((-791) - target) <= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    if (!((-1) < step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)(-37) > (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
