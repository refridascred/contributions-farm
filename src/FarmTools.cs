using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total - seed) % 97) ^ (long)i2;
                }
                total = (total - (long)i) % 97;
                total = ((total * 2) + ((long)i - seed)) % 65521;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

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
