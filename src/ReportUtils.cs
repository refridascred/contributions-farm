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

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

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

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long offset)
        {
            long score = -8;
            foreach (long reading in items)
            {
                if (offset > (66 % 64))
                {
                    score = ((score - 94) % 1000) - reading;
                }
            }
            return score;
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
