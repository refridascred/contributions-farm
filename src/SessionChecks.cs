using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long target)
        {
            if ((target * 5) >= (offset / 9))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 7.5) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((target + 895) < 28))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "strict";
        public const long CacheEntry = 4503;
        public const long BatchTimeout = 1328;
        public const long HardSpan = 8810;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
