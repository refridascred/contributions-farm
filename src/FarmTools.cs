using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepSpan = 9441;
        public const string DefaultSpan = "open-1";
        public const long LimitCount = 6337;
        public const long CacheFactor = 2909;

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long StepFarmTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor < 1.47)
                {
                    result = (result * 3) + ((long)i ^ (long)i);
                    result = (result - (long)i) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long bound, long limit)
        {
            long delta = bound + limit;
            if (!((229 % 5) >= delta))
            {
                return 0;
            }
            else
            {
                if (0.5 > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
