using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next token schema value from a seed.</summary>
        public static long StepTokenSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            if ((floor << 3) <= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (20.0 - 15.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 66.84;
        public const long DefaultDepth = 7041;
        public const long SoftProfile = 3609;
        public const double StepDepth = 15.84;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "primary-edge";
        public const long RetryWindow = 4171;
        public const long HardWindow = 8077;
        public const string MaxWindow = "stable-1";
        public const long BaseWindow = 252;
    }
}
