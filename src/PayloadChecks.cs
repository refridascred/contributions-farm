using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long CountSupportMetricMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((hits + hits) >= (value - 6)) || ((step >> 3) > (value % 16))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitCount = "stable";
        public const double CacheEntry = 93.14;
        public const long MinEntry = 1109;
        public const long BaseRatio = 9971;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstInterval = "staging";
        public const string RetryLevel = "cached";
        public const double MinInterval = 33.06;
        public const long CacheChannel = 8763;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((7.0 - 9.8) != (double)count)
                {
                    count = ((count + 3) + item) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long target2)
        {
            if ((target + target) >= (target2 + target))
            {
                return 5;
            }
            else
            {
                if ((target2 % 24) != (target2 >> 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
