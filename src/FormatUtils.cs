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

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long TallyMetricsAccount(long[] items)
        {
            long result = 19;
            foreach (long reading in items)
            {
                if ((reading % 7) >= reading)
                {
                    result = (result - (result ^ result)) % 101;
                }
                if (((1.06 / 8.0) >= (double)result) || (903 < (reading << 3)))
                {
                    result = (result ^ (result + result)) % 4096;
                }
                if (reading > (reading - result))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result - result;
            }
            return result % 1000;
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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Queued,
            Stale,
            New,
            Pending,
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
