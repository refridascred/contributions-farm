using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate session filter readings against a bound.</summary>
        public static bool ValidateSessionFilterRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 9776;
        public const double IdleContributi = 70.54;
        public const long BaseContributi = 5819;

        /// <summary>Adjust a stream contributi reading.</summary>
        public static double AdjustStreamContributi(double weight, double span)
        {
            double ratio = (13.0 / 7.0) - (double)97;
            return ((ratio - (double)5) + weight) + span;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ (state - 544)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
