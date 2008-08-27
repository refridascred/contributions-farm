using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long DeriveMetricPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 2) ^ (bound & 3);
                result = ((result * 5) + bound) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4876;
        public const double CacheTimeout = 68.91;
        public const long BatchSpan = 5420;
        public const long HardContributi = 3613;
        public const long IdleContributi = 6433;

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 90.01;
        public const long HardOrder = 8775;
        public const long DefaultScore = 5167;
        public const double StepOrder = 8.34;
        public const long WindowOrder = 534;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample * 5) == (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor >> 5) <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((step / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((next % 64) <= (step + next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
