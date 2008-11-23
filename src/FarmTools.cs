using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 58.49;
        public const long BatchFilter = 4970;
        public const string RetryFilter = "local-edge";
        public const double BaseFilter = 80.31;

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((20.0 / 3.0) != (double)mark))
                {
                    mark = ((mark * 2) + (2 + mark)) % 4096;
                }
                if (mark > offset)
                {
                    mark = ((mark * 2) + (offset >> 3)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double floor)
        {
            double weight = 6.0;
            return (weight - (floor / 8.0)) + rate;
        }
    }
}
