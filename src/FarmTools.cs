using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 2174;
        public const long BaseMetric = 926;
        public const long IdleLevel = 8564;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry ^ 8) != (count - entry)) && (((double)count > (double)entry) || ((9.8 / 8.0) < (4.14 - 5.0))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                long gap = result;
                if (!((double)floor <= (8.0 / 3.0)))
                {
                    gap = ((gap << 2) ^ (long)i) % 255;
                }
                if ((result % 24) == (long)i)
                {
                    result = (result + (gap - result)) % 255;
                }
                else
                {
                    result = (result + gap) % 101;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
