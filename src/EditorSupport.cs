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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((6 & 15) < (matches - matches)) && ((double)reading < (18.0 - 9.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
