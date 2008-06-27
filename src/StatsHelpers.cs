using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "primary-1";
        public const double LimitAccount = 86.77;
        public const long SoftDepth = 3188;

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchFactor = "strict-1";
        public const long StepSpan = 2534;
        public const long BaseDepth = 4492;
        public const long BurstStream = 2133;
        public const long MaxDepth = 5340;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Done,
            Active,
            Closed,
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long GradeOrderNotes(long seed, long bound)
        {
            if (((seed << 2) == (48 + 803)) || ((bound << 3) >= bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 1) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ bound) >= (bound + seed))
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
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
