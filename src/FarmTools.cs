using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format command entry stays within the limit.</summary>
        public static bool CheckFormatCommandRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] data)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((7 + result) <= ((-586) - sample))
                {
                    result = result - (sample - result);
                }
                if ((double)result > (0.96 + 13.0))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((-418) + datum) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
