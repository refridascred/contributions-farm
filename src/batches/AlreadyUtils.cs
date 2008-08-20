using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8678;
        public const double StepProfile = 48.61;
        public const string SoftSize = "stable-1";
        public const string RetryProfile = "strict-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (2.1 / 9.0))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats batches readings.</summary>
        public static long FoldStatsBatches(long[] readings)
        {
            long state = 75;
            foreach (long datum in readings)
            {
                state = state - (state ^ datum);
                if ((20.0 - 7.0) < (double)state)
                {
                    state = (state + (state + (-508))) % 101;
                }
                else
                {
                    state = (state - (state * 5)) % 101;
                }
            }
            if (state < 174)
            {
                state = state + (state << 2);
            }
            return state;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (4 % 64)) % 4096;
                sum = ((sum << 2) ^ 1) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
