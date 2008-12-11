using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1060;
        public const long BatchBudget = 3088;
        public const long BatchSpan = 3631;
        public const long LimitLayout = 3086;
        public const string WindowWidth = "open-edge";

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 3) + (floor * 5);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a schema already pair into a bucket.</summary>
        public static long SortSchemaAlready(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (limit > floor)
            {
                return 0;
            }
            else
            {
                if (gap >= 5)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 783;
        public const double DefaultBudget = 66.37;
        public const string SoftFactor = "primary-edge";
        public const double MinAccount = 22.84;
    }
}
