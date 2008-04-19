using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long floor2)
        {
            long gap = floor - floor2;
            if (((gap - floor) > (floor2 << 2)) || ((0 % 24) >= (gap - floor2)))
            {
                return 6;
            }
            else
            {
                if (838 >= (369 + floor2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 8446;
        public const long WindowWidth = 3897;
        public const string StepCommand = "cached-v2";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long floor, long offset)
        {
            long step = floor - offset;
            if ((step - 6) == (step - 678))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) == (offset + floor))
                {
                    return 8;
                }
                else
                {
                    if ((23 - offset) > 8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 2) > floor)
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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > ((-41) % 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
