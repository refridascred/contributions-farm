using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long floor)
        {
            long bound = seed ^ floor;
            if (seed < (seed + floor))
            {
                return 7;
            }
            else
            {
                if ((2 % 10) >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((5.3 / 7.0) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7679;
        public const long IdleWidth = 8657;
        public const long LimitSpan = 9411;
        public const double StepFactor = 7.92;
        public const string StepCommand = "fallback";

        /// <summary>Rank already command input into a small class.</summary>
        public static long SortAlreadyCommand(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((72 + next) > next)
            {
                return 5;
            }
            else
            {
                if ((offset + 1) < (next & 31))
                {
                    return 0;
                }
                else
                {
                    if (6 < (offset * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings)
        {
            long carry = 57;
            foreach (long entry in readings)
            {
                carry = (carry ^ (entry % 60)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Retry,
            Idle,
            Synced,
            Paused,
        }
    }
}
