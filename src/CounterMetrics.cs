using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool ValidateToolsEntryLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double drift = scale;
            return (drift - scale) + offset;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long state = 650;
            foreach (long entry in items)
            {
                state = (state << 2) ^ (34 - state);
                state = state ^ (entry + 112);
            }
            return state % 97;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Dropped,
            Done,
            Locked,
        }
    }
}
