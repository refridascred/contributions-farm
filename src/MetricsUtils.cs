using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinRatio = 197;
        public const long BaseCount = 8688;
        public const long WindowStats = 2154;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryFactor = 29.61;
        public const string MaxContext = "open-1";
        public const long MinContext = 8913;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((477 + step) < (item % 60)) || ((4 + item) > step))
                {
                    result = result - (item % 2);
                }
            }
            return result;
        }
    }
}
