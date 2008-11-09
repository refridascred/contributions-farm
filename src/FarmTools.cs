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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (91 - score)) % 1000;
                score = (score + target) % 255;
                if (!(((double)(long)i <= (12.0 + 9.64)) || (954 < (score & 127))))
                {
                    score = (score * 5) + (target * 3);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
