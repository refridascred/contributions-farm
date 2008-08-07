using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1135;
        public const long CacheGraph = 4581;
        public const long StepGraph = 3781;
        public const double DefaultGraph = 40.43;

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "stable-edge";
        public const string StepTimeout = "staging-1";
        public const long HardFactor = 886;
        public const double HardSize = 59.31;

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset ^ step) == (offset * 5))
            {
                return 5;
            }
            else
            {
                if (!((step >> 3) != (offset / 4)))
                {
                    return 0;
                }
                else
                {
                    if (((step - origin) <= (offset >> 3)) || ((19.0 - 4.43) >= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (origin % 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
