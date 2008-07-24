using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-edge";
        public const string StepSpan = "latest-edge";
        public const double HardCounter = 41.92;
        public const long RetryCounter = 6127;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double weight2 = (double)75;
            return ((weight2 + (weight2 * 0.4)) + weight) + offset;
        }
    }
}
