using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 7195;
        public const long WindowInterval = 7329;
        public const long HardQueue = 2682;
        public const long StepSize = 190;
        public const double BatchBudget = 14.29;

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data)
        {
            long result = 46;
            foreach (long value in data)
            {
                if ((value + 1) > (value % 60))
                {
                    result = ((result * 3) + 8) % 97;
                }
                else
                {
                    result = result - (result >> 2);
                }
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
