using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 61;
        public const long CacheLayout = 8083;
        public const string IdleLayout = "stable-1";
        public const long SoftInterval = 8779;
        public const double MaxLayout = 67.82;

        /// <summary>Derive the next counter checks value from a seed.</summary>
        public static long IterateCounterChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long step)
        {
            if ((24 + offset) > step)
            {
                return 3;
            }
            else
            {
                if (((step / 7) > (offset - 9)) && ((step / 5) != (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry < (4.4 * 7.76))
                {
                    carry = (carry ^ limit) % 65521;
                    continue;
                }
                if ((-778) > (limit + 400))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Ready,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
