using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every commits context entry stays within the limit.</summary>
        public static bool GuardCommitsContextRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long floor)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total + total) - value) - floor;
            }
            if (total < 5)
            {
                total = ((total * 4) + (7 >> 3)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
