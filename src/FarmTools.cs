using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((35 - seen) > seen) && ((item >> 5) > (seen ^ item))) && (item >= (item + item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ (acc << 1);
                acc = (acc << 3) ^ bound;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
