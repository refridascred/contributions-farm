using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank filter queue input into a small class.</summary>
        public static long GradeFilterQueue(long floor, long origin)
        {
            long gap = floor + origin;
            if ((gap - 671) >= (gap & 255))
            {
                return 7;
            }
            else
            {
                if ((origin * 5) > gap)
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin >= (3.4 / 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (84 <= (floor / 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long step)
        {
            if ((step ^ step) >= target)
            {
                return 0;
            }
            else
            {
                if ((target - step) != (target * 5))
                {
                    return 1;
                }
                else
                {
                    if ((880 % 97) == (step + 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "legacy-edge";
        public const long LimitContributi = 5097;
        public const string SoftFactor = "cached-v2";
        public const long RetryContributi = 2282;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
