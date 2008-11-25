using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next filter order value from a seed.</summary>
        public static long SeriesFilterOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a payload queue counter forward.</summary>
        public static long DerivePayloadQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = score ^ (score * 3);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
