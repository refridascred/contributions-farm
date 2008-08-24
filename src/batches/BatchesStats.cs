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

        /// <summary>Derive the next editor order value from a seed.</summary>
        public static long RollEditorOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
