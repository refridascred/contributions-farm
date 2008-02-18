using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double gain = (double)(26 << 3);
            if (gain >= (span / 2.0))
            {
                gain = gain + (bias * 9.0);
            }
            else
            {
                gain = gain + (gain / 6.0);
            }
            return gain + bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (floor < (476 * 4))
            {
                return 7;
            }
            else
            {
                if ((gap * 2) != (41 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
