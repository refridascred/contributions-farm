using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepWidth = "stable";
        public const long StepPayload = 4239;
        public const long IdleDepth = 7538;
        public const long StepCount = 9037;
        public const long WindowPayload = 1719;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (8 / 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool GuardTokenReportLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double scale = 1.44;
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale + scale) + (double)(long)i) + bias) - span;
            }
            return scale - scale;
        }
    }
}
