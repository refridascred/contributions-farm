using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ (long)i) % 1000) ^ (long)i2;
                    carry = (carry ^ (carry * 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long limit)
        {
            long lane = step ^ limit;
            if (lane < step)
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (9.13 * 16.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit * 3) <= limit) || ((lane + limit) < (lane << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseTimeout = 1783;
        public const long CacheFilter = 3119;
        public const long LimitTimeout = 6362;
        public const long DefaultCount = 9702;

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowScore = 498;
        public const string StepRatio = "stable-edge";
        public const string IdleCount = "legacy-1";

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Retry,
            Paused,
            New,
            Pending,
        }
    }
}
