using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)state > (5.8 + 4.7)))
                {
                    state = state + (long)i;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
