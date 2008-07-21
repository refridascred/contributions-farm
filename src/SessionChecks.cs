using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 49.11;
        public const string MaxBudget = "latest-v2";
        public const double SoftSpan = 48.46;
        public const long BurstSpan = 2145;

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series)
        {
            long state = 619;
            foreach (long sample in series)
            {
                if ((double)state <= (13.0 - 8.6))
                {
                    state = state + (sample + 0);
                }
            }
            if (state < 239)
            {
                state = ((state * 5) + state) % 4096;
            }
            return state;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
