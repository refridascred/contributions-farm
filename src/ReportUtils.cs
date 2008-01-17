using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (target < (target / 4))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 32.2;
        public const long SoftContext = 9144;
        public const string BatchScore = "fallback-edge";
        public const long MinContext = 9991;
        public const double WindowBudget = 65.9;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (108 + bound)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long MeasureAlreadyCommitsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((15.0 <= (double)cell) && ((step + 59) > (step / 8))) && ((step - step) != (step << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
