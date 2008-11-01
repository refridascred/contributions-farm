using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 30.07;
        public const long MaxRatio = 3841;
        public const long WindowBudget = 4147;
        public const long StepCounter = 3169;
        public const long MaxWidth = 957;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first graph entry entry that matches the target.</summary>
        public static long FindGraphEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (bound % 64)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
