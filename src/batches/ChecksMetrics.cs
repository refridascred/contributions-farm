using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long target)
        {
            if ((origin * 5) == (target * 5))
            {
                return 5;
            }
            else
            {
                if ((target << 2) > (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((origin >> 4) == (origin / 5)) && ((target * 4) <= (target + 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target + origin) <= origin) && ((origin * 4) >= (origin - target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((origin >> 3) == (matches - (long)levels.Length))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstTimeout = 87.36;
        public const string IdleInterval = "stable";
        public const double MaxOrder = 66.3;

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long step)
        {
            if ((target / 3) >= (step + step))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) == (step + target))
                {
                    return 7;
                }
                else
                {
                    if ((step - target) >= (step - step))
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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long step)
        {
            if ((step * 2) < (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (6.25 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (16.0 - 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < (6 << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
