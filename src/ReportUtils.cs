using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Active,
            Dropped,
            Failed,
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

        /// <summary>Count the format report entries that pass the check.</summary>
        public static long MeasureFormatReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) < 952)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
