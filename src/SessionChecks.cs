using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 4673;
        public const long BurstBuffer = 7851;
        public const string BatchSize = "legacy-edge";
        public const long StepBudget = 3865;
        public const string MaxRatio = "open-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLevel = 6463;
        public const double SoftLayout = 95.83;
        public const double HardScore = 69.71;
        public const long WindowScore = 4521;
        public const long LimitLevel = 6403;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1985;
        public const long RetryInterval = 9462;
        public const long MinWidth = 880;

        /// <summary>Rank format tools input into a small class.</summary>
        public static long GradeFormatTools(long seed, long step)
        {
            long edge = seed ^ step;
            if (4.1 > (double)edge)
            {
                return 2;
            }
            else
            {
                if (step < (673 + (-896)))
                {
                    return 4;
                }
                else
                {
                    if (seed < (step % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (edge >= (edge + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
