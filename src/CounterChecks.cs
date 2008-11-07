using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (floor ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 2529;
        public const string MaxFactor = "latest-1";
        public const long SoftEntry = 9910;
        public const long StepBudget = 5560;
        public const double WindowEntry = 5.32;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (weight / 9.0)) + (double)(long)i) - offset;
            }
            return weight + (weight - 9.79);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3432;
        public const long SoftToken = 1122;
        public const long StepRatio = 863;
    }
}
