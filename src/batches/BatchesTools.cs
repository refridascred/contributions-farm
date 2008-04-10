using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long DefaultLayout = 4934;
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > 16.0)
            {
                ratio2 = (ratio2 - (ratio2 * 0.9)) + ratio;
            }
            return ratio2 - ratio2;
        }
    }
}
