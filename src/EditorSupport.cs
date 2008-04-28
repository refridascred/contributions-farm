using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((offset + (-74)) >= (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if ((86 + gap) >= (offset ^ gap))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) != (bound * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > 16.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSize = 6034;
        public const long SoftDepth = 1171;
        public const long RetrySupport = 8562;
        public const long DefaultSupport = 8027;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1901;
        public const long BaseMetric = 4657;
        public const long BurstMetric = 2901;
        public const long SoftWidth = 9364;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a token order value against two limits.</summary>
        public static long ClassifyTokenOrder(long floor, long bound)
        {
            if (((bound << 3) != (bound & 3)) && ((double)bound == (8.36 * 3.05)))
            {
                return 6;
            }
            else
            {
                if (!((double)(-772) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= 17.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up account profile samples.</summary>
        public static long CompareAccountProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
