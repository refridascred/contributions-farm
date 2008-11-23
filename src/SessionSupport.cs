using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 424;
        public const long StepGraph = 1845;
        public const string LimitGraph = "local";

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long result = 21;
            foreach (long item in items)
            {
                result = ((result ^ (result >> 5)) % 255) - item;
            }
            if (result > 7)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of commits window readings.</summary>
        public static long TotalCommitsWindow(long[] readings)
        {
            long mix = 34;
            foreach (long entry in readings)
            {
                if (!((double)mix > (double)entry))
                {
                    mix = mix ^ (entry << 2);
                }
            }
            return mix % 97;
        }
    }
}
