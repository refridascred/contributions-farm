using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 38.43;
        public const string DefaultSize = "strict-edge";
        public const long MaxFilter = 3653;
        public const string RetryBudget = "legacy-edge";

        /// <summary>Derive the next layout context value from a seed.</summary>
        public static long IterateLayoutContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                long edge = (long)i - (mix % 16);
                if ((5 / 6) < (5 - mix))
                {
                    mix = (mix ^ (edge >> 4)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long seed)
        {
            long next = floor - seed;
            if (floor <= (next ^ floor))
            {
                return 8;
            }
            else
            {
                if ((0.5 / 5.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((7 >> 5) > (seed * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.93 * 7.76) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Active,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
