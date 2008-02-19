using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double offset)
        {
            double ratio = (double)(1 << 3);
            return (ratio - weight) + offset;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum < (15.0 / 2.0)) || ((tally + (long)data.Length) <= datum)))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound < (bound + state))
                {
                    state = state - (40 + state);
                    state = state ^ (bound << 3);
                }
                if ((6 << 1) >= state)
                {
                    state = (state * 4) + (bound + bound);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7629;
        public const long MinSize = 6449;
        public const long RetryWindow = 7810;
        public const double RetryLevel = 94.61;
    }
}
