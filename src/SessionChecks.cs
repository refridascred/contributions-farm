using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1805;
        public const long StepSize = 5929;
        public const string StepAccount = "local-v2";
        public const long RetryAccount = 9375;

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= weight)
            {
                weight2 = (weight2 - (weight2 * 6.04)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + weight) - (double)(long)i;
            }
            return weight2 - 2.4;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the tools report series from a seed.</summary>
        public static long SeriesToolsReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ 353) % 1000) + (long)i2;
                }
                acc = acc + acc;
                acc = (acc << 3) ^ (bound + bound);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
