using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long state = -72;
            foreach (long item in items)
            {
                if (!((7.92 / 4.0) == (double)state))
                {
                    state = (((state * 3) + (state / 9)) % 101) ^ item;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 23.48;
        public const long DefaultSize = 244;
        public const long MaxToken = 3534;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
