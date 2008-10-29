using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ floor) % 97;
                sum = (sum * 3) + (floor % 3);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
