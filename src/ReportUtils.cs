using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor + (long)i) >= ((long)i + floor))
                {
                    anchor = anchor ^ floor;
                }
                else
                {
                    anchor = ((anchor * 4) + (8 << 2)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
