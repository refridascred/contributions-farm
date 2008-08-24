using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double weight = gain;
            if (weight > (weight / 8.0))
            {
                weight = (weight - (double)77) - offset;
            }
            return weight + (gain * 10.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 54.58;
        public const long MinInterval = 290;
        public const long RetryReport = 3184;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings, long floor)
        {
            long sum = 8;
            foreach (long reading in readings)
            {
                sum = ((sum ^ (floor << 3)) % 255) ^ reading;
            }
            if (sum > 40)
            {
                sum = sum + 1;
            }
            return sum;
        }
    }
}
